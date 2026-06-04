--Note: some of these scripts are needed for specific items, when the instructions say "specific" pick one item in your data and specify it in the where clause using a unique value that identifies it, do not use the primary key.

--1) Sometimes when a staff member is fired. We need to eradicate everything from that user in our system. Write the SQL to delete a specific user and all the user's related records.
delete rcm
--select *
from RecipeCourseMeal rcm
join Recipe r
on r.RecipeId = rcm.RecipeId
join WebUser w
on w.WebUserId = r.WebUserId
where w.WebUserName = 'emorris'

delete cm
--select *
from CourseMeal cm
join Meal m
on m.MealId = cm.MealId
join WebUser w
on w.WebUserId = m.WebUserId
where w.WebUserName = 'emorris'

delete rc
--select *
from RecipeCookBook rc
join Recipe r
on rc.RecipeId = r.RecipeId
join WebUser w
on w.WebUserId = r.WebUserId
where w.WebUserName = 'emorris'

delete ri
--select *
from RecipeIngredient ri
join Recipe r
on ri.RecipeId = r.RecipeId
join WebUser w
on w.WebUserId = r.WebUserId
where w.WebUserName = 'emorris'

delete d
--select *
from Direction d
join Recipe r
on r.RecipeId = d.RecipeId
join WebUser w
on w.WebUserId = r.WebUserId
where w.WebUserName = 'emorris'

delete b
--select *
from CookBook b
join WebUser w
on b.WebUserId = w.WebUserId
where w.WebUserName = 'emorris'

delete m
--select *
from Meal m
join WebUser w
on w.WebUserId = m.WebUserId
where w.WebUserName = 'emorris'

delete r
--select *
from Recipe r
join WebUser w
on w.WebUserId = r.WebUserId
where w.WebUserName = 'emorris'

delete w
--select *
from WebUser w
where w.WebUserName = 'emorris'

--2) Sometimes we want to clone a recipe as a starting point and then edit it. For example we have a complex recipe (steps and ingredients) and want to make a modified version. Write the SQL that clones a specific recipe, add " - clone" to its name.
insert Recipe(WebUserId, CuisineId, RecipeName, DateDrafted, DatePublished, DateArchived, AmountCalories)
select r.WebUserId, r.CuisineId, r.RecipeName + ' - clone', r.DateDrafted, r.DatePublished, r.DateArchived, r.AmountCalories
from Recipe r
where r.RecipeName = 'Apple Yogurt Smoothie'

;
with x as(
	select
	OldId = (select r.RecipeId from Recipe r where r.RecipeName = 'Apple Yogurt Smoothie'),
	NewId = (select r.RecipeId from Recipe r where r.RecipeName = 'Apple Yogurt Smoothie - clone')
)
insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, MeasurementAmount, IngredientSequence)
select x.NewId, ri.IngredientId, ri.Measurementid, ri.MeasurementAmount, ri.IngredientSequence
from x
join RecipeIngredient ri
on x.OldId = ri.RecipeId

;
with x as(
	select
	OldId = (select r.RecipeId from Recipe r where r.RecipeName = 'Apple Yogurt Smoothie'),
	NewId = (select r.RecipeId from Recipe r where r.RecipeName = 'Apple Yogurt Smoothie - clone')
)

insert Direction(RecipeId, RecipeSequence, RecipeDirection)
select x.NewId, d.RecipeSequence, d.RecipeDirection
from x
join Direction d
on x.OldId = d.DirectionId

/*
3) We offer users an option to auto-create a recipe book containing all of their recipes. 
Write a SQL script that creates the book for a specific user and fills it with their recipes.
The name of the book should be Recipes by Firstname Lastname. 
The price should be the number of recipes multiplied by $1.33
Sequence the book by recipe name.

Tip: To get a unique sequential number for each row in the result set use the ROW_NUMBER() function. See Microsoft Docs.
	 The following can be a column in your select statement: Sequence = ROW_NUMBER() over (order by colum name) , replace column name with the name of the column that the row number should be sorted
*/
insert CookBook(WebUserId, CookBookName, CookBookPrice, DateCookBookCreated, Active)
select w.WebUserId, 'Recipes by Hindy Lauer', CookBookPrice = (count(r.RecipeId) * 1.33 ), '01/20/21', 1
from WebUser w
join Recipe r
on r.WebUserId = w.WebUserId
where w.WebUserName = 'hlauer'
group by w.WebUserId

insert RecipeCookBook(RecipeId, CookBookId, RecipeSequence)
select r.RecipeId, b.CookBookId, ROW_NUMBER() over(order by r.RecipeName)
from CookBook b
cross join Recipe r
join WebUser w
on r.WebUserId = w.WebUserId
where w.WebUserName = 'hlauer'
and b.CookBookName = 'Recipes by Hindy Lauer'

/*
4) Sometimes the calorie count of of an ingredient changes and we need to change the calorie total for all recipes that use that ingredient.
Our staff nutritionist will specify the amount to change per measurement type, and of course multiply the amount by the quantity of the ingredient.
For example, the calorie count for butter went down by 2 per ounce, and 10 per stick of butter. 
Write an update statement that changes the number of calories of a recipe for a specific ingredient. 
The statement should include at least two measurement types, like the example above. 
*/
update r 
set r.AmountCalories = r.AmountCalories + (case when m.MeasurementDesc = 'cup' then +1 when m.MeasurementDesc = 'tsp' then +2  else 0 end) * ri.MeasurementAmount 
from Recipe r
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
join Ingredient i
on i.IngredientId = ri.IngredientId
join Measurement m
on m.MeasurementId = ri.MeasurementId
where i.IngredientName = 'Flour'

/*
5) We need to send out alerts to users that have recipes sitting in draft longer the average amount of time that recipes have taken to be published.
Produce a result set that has 4 columns (Data values in brackets should be replaced with actual data)
	User First Name, 
	User Last Name, 
	email address (first initial + lastname@heartyhearth.com),
	Alert: 
		Your recipe [recipe name] is sitting in draft for [X] hours.
		That is [Z] hours more than the average [Y] hours all other recipes took to be published.
*/
;
with x as(
select AvgHoursToBePublished = avg(datediff(hour, r.DateDrafted, r.DatePublished))
from Recipe r
)
select w.WebUserFirstName, w.WebUserLastName, EmailAddress = concat(lower(substring(w.WebUserFirstName, 1,1)), lower(w.WebUserLastName), '@heartyhearth.com'), 
Alert = concat('Your recipe ', lower(r.RecipeName), ' is sitting in draft for ', datediff(hour, r.DateDrafted, getdate()), ' hours. That is ', (datediff(hour, r.DateDrafted, getdate()) - x.AvgHoursToBePublished), ' hours more than the average ', x.AvgHoursToBePublished, ' hours all other recipes took to be published.')
from Recipe r
join WebUser w
on w.WebUserId = r.WebUserId
cross join x
where datediff(hour, r.DateDrafted, getdate()) > x.AvgHoursToBePublished
and r.RecipeStatus = 'Drafted'

/*
6) We want to send out marketing emails for books. Produce a result set with one row and one column "Email Body" as specified below.
The email should have a unique guid link to follow, which should be shown in the format specified. 

Email Body:
Order cookbooks from HeartyHearth.com! We have [X] books for sale, average price is [Y]. You can order them all and receive a 25% discount, for a total of [Z].
Click <a href = "www.heartyhearth.com/order/[GUID]">here</a> to order.
*/
select EmailBody = concat('Order cookbooks from HeartyHearth.com! We have ', count(b.CookBookId),
' books for sale, average price is ', cast(avg(b.CookBookPrice) as decimal(10,2)), '.', ' You can order them all and receive a 25% discount, for a total of ', cast(sum(b.CookBookPrice) * .75 as decimal(10,2)),
'. Click <a href = "www.heartyhearth.com/order/', newid(), '">here</a> to order.')
from CookBook b
