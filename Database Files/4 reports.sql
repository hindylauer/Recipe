Use HeartyHearthDB
go
/*
Our website development is underway! 
Below is the layout of the pages on our website, please provide the SQL to produce the necessary result sets.

Note: 
a) When the word 'specific' is used, pick one record (of the appropriate type, recipe, meal, etc.) for the query. 
    The way the website works is that a list of items are displayed and then the user picks one and navigates to the "details" page.
b) Whenever you have a record for a specific item include the name of the picture for that item. That is because the website will always show a picture of the item.
*/

/*
Home Page
    One result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
*/
select ItemName = 'Recipe', Count = count(*) from Recipe 
union select 'Meal', count(*) from Meal
union select 'CookBook', count(*) from CookBook b

/*
Recipe list page:
    List of all Recipes that are either published or archived, published recipes should appear at the top. Archived recipes should appear gray on the website.
	In order for the recipe name to be gray on the website, surround the archived recipe names with: <span style="color:gray">recipe name<span style="color:gray">
    In the resultset show the Recipe with its status, dates it was published and archived in mm/dd/yyyy format (blank if not archived), user, number of calories and number of ingredients.
    Tip: You'll need to use the convert function for the dates
*/
select RecipeName = case when r.RecipeStatus = 'Archived' then concat('<span style="color:gray">', r.RecipeName, '<span style="color:gray">') else r.RecipeName end, 
       r.RecipeStatus, DatePublished = convert(varchar(10), r.DatePublished, 101),
       DateArchived = isnull(convert(varchar(10), r.DateArchived, 101), ''),
       w.WebUserName, r.AmountCalories,
       AmountIngredients = count(ri.RecipeIngredientId)
from Recipe r
join WebUser w
on w.WebUserId = r.WebUserId
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
where r.RecipeStatus in('Published', 'Archived')
group by r.RecipeName, r.RecipeStatus, r.DatePublished, r.DateArchived, w.WebUserName, r.AmountCalories
order by r.RecipeStatus desc

/*
Recipe details page:
    Show for a specific recipe (three result sets):
        a) Recipe header: recipe name, number of calories, number of ingredients and number of steps.
        b) List of ingredients: show the measurement quantity, measurement type and ingredient in one column, sorted by sequence. Ex. 1 Teaspoon Salt  
        c) List of prep steps sorted by sequence.
*/
--a
select r.RecipeName, r.AmountCalories, NumIngredients = count(distinct ri.RecipeIngredientId), NumSteps = count(distinct d.DirectionId), r.RecipeImage
from Recipe r
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join Direction d
on d.RecipeId = r.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'
group by r.RecipeName, r.AmountCalories, r.RecipeImage
--b
select ListofIngredients = concat(format(ri.MeasurementAmount, '0'), case when m.MeasurementDesc is not null then ' ' else ' ' end, m.MeasurementDesc, ' ', i.IngredientName), i.IngredientImage
from Ingredient i
join RecipeIngredient ri
on i.IngredientId = ri.IngredientId
join Recipe r
on r.RecipeId = ri.RecipeId
left join Measurement m
on m.MeasurementId = ri.MeasurementId
where r.RecipeName = 'Chocolate Chip Cookies'
order by ri.IngredientSequence
--c
select d.RecipeDirection
from Direction d
join Recipe r
on r.RecipeId = d.RecipeId
where r.RecipeName = 'Chocolate Chip Cookies'
order by d.RecipeSequence

/*
Meal list page:
    For all active meals, show the meal name, user that created the meal, number of calories for the meal, number of courses, and number of recipes per each meal, sorted by name of meal
*/
select m.MealName, w.WebUserName, NumCalories = sum(r.AmountCalories), NumCourses = count(rcm.RecipeCourseMealId), NumRecipesPerMeal = count(r.RecipeId)
from Meal m
join WebUser w
on m.WebUserId = w.WebUserId
join CourseMeal cm
on cm.MealId = m.MealId
join RecipeCourseMeal rcm
on rcm.CourseMealId = cm.CourseMealId
join Recipe r
on r.RecipeId = rcm.RecipeId
where m.Active = 1
group by m.MealName, m.MealId, w.WebUserName
order by m.MealName

/*
Meal details page:
    Show for a specific meal:
        a) Meal header: meal name, user, date created.
        b) List of all recipes: Result set should have one column, including the course type, whether the dish is served as main/side (if it's the main course), and recipe name. 
			Format for main course: CourseType: Main/Side dish - Recipe Name. 
            Format for non-main course: CourseType: Recipe Name
            Main dishes of the main course should be bold, using the bold tags as shown below
                ex: 
                    Appetizer: Mixed Greens
                    <b>Main: Main dish - Onion Pastrami Chicken</b>
					Main: Side dish - Roasted cucumbers with mustard
*/
--a
select m.MealName, w.WebUserName, m.DateMealCreated, m.MealImage
from Meal m
join WebUser w
on w.WebUserId = m.WebUserId
where m.MealName = 'Supper Spectacular'
--b
select ListOfRecipes = case when c.CourseName = 'Main' then case when rcm.CourseType = 1
                        then concat('<b>Main: Main dish - ', r.RecipeName, '</b>')
                        else concat('Main: Side dish - ', r.RecipeName) end
                        else concat(c.CourseName, ': ', r.RecipeName) end
from RecipeCourseMeal rcm
join Recipe r
on r.RecipeId = rcm.RecipeId
join CourseMeal cm
on cm.CourseMealId = rcm.CourseMealId
join Meal m
on m.MealId = cm.MealId
join Course c
on c.CourseId = cm.CourseId
where m.MealName = 'Supper Spectacular'
order by c.CourseSequence, rcm.CourseType desc

/*
Cookbook list page:
    Show all active cookbooks with author and number of recipes per book. Sorted by book name.
*/
select b.CookBookName, w.WebUserName, NumRecipesPerBook = count(rc.RecipeCookBookId)
from CookBook b
join WebUser w
on w.WebUserId = b.WebUserId
left join RecipeCookBook rc
on rc.CookBookId = b.CookBookId
where b.Active = 1
group by b.CookBookName, w.WebUserName
order by b.CookBookName

/*
Cookbook details page:
    Show for specific cookbook:
    a) Cookbook header: cookbook name, user, date created, price, number of recipes.
    b) List of all recipes in the correct order. Include recipe name, cuisine and number of ingredients and steps.  
        Note: User will click on recipe to see all ingredients and steps.
*/
--a
select b.CookBookName, w.WebUserName, b.DateCookBookCreated, b.CookBookPrice, NumRecipes = count(rc.CookBookId), b.CookBookImage
from CookBook b
join WebUser w
on w.WebUserId = b.WebUserId
join RecipeCookBook rc
on rc.CookBookId = b.CookBookId
where b.CookBookName = 'Health Nut'
group by b.CookBookName, w.WebUserName, b.DateCookBookCreated, b.CookBookPrice, b.CookBookImage

--b
select r.RecipeName, c.CuisineName, NumIngredients = (select count(*) from RecipeIngredient ri where ri.RecipeId = r.RecipeId), NumSteps = (select count(*) from Direction d where d.RecipeId = r.RecipeId)
from Recipe r
join Cuisine c
on c.CuisineId = r.CuisineId
join RecipeCookBook rc
on rc.RecipeId = r.RecipeId
join CookBook b
on b.CookBookId = rc.CookBookId
where b.CookBookName = 'Health Nut'
order by rc.RecipeSequence

/*
April Fools Page:
    On April 1st we have a page with a joke cookbook. For that page provide the following.
    a) A list of all the recipes that are in all cookbooks. The recipe name should be the reverse of the real name with the first letter capitalized and all others lower case.
        There are matching pictures for those names, include the reversed picture names so that we can show the joke pictures.
        Note: ".jpg" file extension must be at the end of the reversed picture name EX: Recipe_Seikooc_pihc_etalocohc.jpg
    b) When the user clicks on any recipe they should see a spoof steps lists showing the step instructions for the LAST step of EACH recipe in the system. No sequence required.
        Hint: Use CTE
*/
--a
select distinct RecipeName = concat(upper(substring(reverse(r.RecipeName), 1,1)), lower(substring(reverse(r.RecipeName), 2, len(r.RecipeName)))),
RecipeImage = replace(concat('Recipe_', upper(substring(reverse(r.RecipeName), 1,1)), lower(substring(reverse(r.RecipeName), 2, len(r.RecipeName))), '.jpg'), ' ', '_')
from RecipeCookBook rc
join Recipe r
on r.RecipeId = rc.RecipeId
group by r.RecipeId, r.RecipeName, r.RecipeImage

--b
;
with x as(
    select LastStep = max(d.RecipeSequence), r.RecipeName, r.RecipeId
    from Direction d
    join Recipe r
    on r.RecipeId = d.RecipeId
    group by r.RecipeName, r.RecipeId
)
select x.RecipeName, d.RecipeSequence
from x
join Direction d
on x.LastStep = d.RecipeSequence
and d.RecipeId = x.RecipeId
order by x.RecipeName

/*
For site administration page:
5 seperate reports
    a) List of how many recipes each user created per status. Show 0 if user has no recipes at all.
    b) List of how many recipes each user created and average amount of days that it took for the user's recipes to be published.
    c) For each user, show three columns: Total number of meals, Total Active meals, Total Inactive meals. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    d) For each user, show three columns: Total number of cookbooks, Total Active cookbooks, Total Inactive cookbooks. Show 0 if none
        Hint: For active/inactive columns, use SUM function with CASE to only include in sum if active/inactive 
    e) List of archived recipes that were never published, and how long it took for them to be archived.
*/
--a
select NumRecipes = count(r.WebUserId), w.WebUserName, RecipeStatus = isnull(r.RecipeStatus, '')
from WebUser w
left join Recipe r
on w.WebUserId = r.WebUserId
group by w.WebUserId, w.WebUserName, r.RecipeStatus

--b
select NumRecipes = count(r.RecipeId), w.WebUserName, AvgAmtDays = avg(datediff(day, DateDrafted, DatePublished))
from WebUser w
left join Recipe r
on w.WebUserId = r.WebUserId
group by w.WebUserId, w.WebUserName

--c
select TotalNumMeals = count(m.MealId), TotalActiveMeals = isnull(sum(case when m.Active = 1 then 1 else 0 end), 0), TotalInactiveMeals = isnull(sum(case when m.Active = 0 then 1 else 0 end), 0)
from WebUser w
left join Meal m
on m.WebUserId = w.WebUserId
group by w.WebUserId

--d
select TotalCookBooks = count(b.CookBookId), TotalActiveCookBook = isnull(sum(case when b.Active = 1 then 1 else 0 end), 0), TotalInactiveCookBook = isnull(sum(case when b.Active = 0 then 1 else 0 end), 0)
from WebUser w
left join CookBook b
on w.WebUserId = b.WebUserId
group by w.WebUserId

--e
select r.RecipeName, AmountDays = datediff(day, DateDrafted, DateArchived)
from Recipe r
where r.RecipeStatus = 'Archived'
and r.DatePublished is null

/*
For user dashboard page:
    a) For a specific user, show one result set with the number of recipes, meals, and cookbooks. Each row should have a column with the item name (Ex: Recipes) and a column with the count.
        Tip: If you would like, you can use a CTE to get the User Id once instead of in each union select
    b) List of the user's recipes, display the status and the number of hours between the status it's in and the one before that. Omit recipes in drafted status.
    
    OPTIONAL CHALLENGE QUESTION
    c) Show a list of cuisines and the count of recipes the user has per cuisine, 0 if none
        Hint: Start by writing a CTE to give you cuisines for which the user does have recipes. 
*/
--a
;
with x as(
select w.WebUserId
from WebUser w
where w.WebUserName = 'emorris'
)
select ItemName = 'Recipe', Count = count(r.RecipeId)
from Recipe r
join x
on x.WebUserId = r.WebUserId
union select 'Meal', count(m.MealId)
from Meal m
join x
on m.WebUserId = x.WebUserId
union select 'CookBook', count(b.CookBookId)
from CookBook b
join x
on b.WebUserId = x.WebUserId

--b
select r.RecipeStatus, NumHours = datediff(hour, case when r.RecipeStatus = 'Published' then r.DateDrafted when r.RecipeStatus = 'Archived' then isnull(r.DatePublished, r.DateDrafted) end,  
case when r.RecipeStatus = 'Published' then r.DatePublished when r.RecipeStatus = 'Archived' then r.DateArchived end)
from WebUser w
left join Recipe r
on w.WebUserId = r.WebUserId
where w.WebUserName = 'emorris'
and r.RecipeStatus <> 'drafted'

--challenge
;
with x as(
select c.CuisineId, c.CuisineName, w.WebUserName, r.RecipeId
from Cuisine c
join Recipe r
on r.CuisineId = c.CuisineId
join WebUser w
on w.WebUserId = r.WebUserId
where w.WebUserName = 'emorris'
)
select NumRecipes = count(x.RecipeId), c.CuisineName
from Cuisine c
left join x
on x.CuisineId = c.CuisineId
group by c.CuisineName

