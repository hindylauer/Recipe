--AS You were missing a using, I added it in
use HeartyHearthDB
go

delete RecipeCookBook
delete CookBook
delete RecipeCourseMeal
delete CourseMeal
delete Course
delete Meal
delete Direction
delete RecipeIngredient
delete Measurement
delete Ingredient
delete Recipe
delete Cuisine
delete WebUser


insert Cuisine(CuisineName)
select 'American'
union select 'French'
union select 'English'
go

insert WebUser(WebUserFirstName, WebUserLastName, WebUserName)
select 'Hindy', 'Lauer', 'hlauer'
union select 'Chavi', 'Beer', 'cbeer'
union select 'Esther', 'Morris', 'emorris'
union select 'Raizy', 'Weinberg', 'rweinberg'
union select 'Elazar', 'Lauer', 'elauer'
union select 'Yossi', 'Lauer', 'ylauer'
union select 'Mordy', 'Lauer', 'mlauer'
go

;
with x as(
    select WebUserName = 'hlauer', CuisineName = 'American', RecipeName = 'Chocolate Chip Cookies', DateDrafted = '02/05/2020', DatePublished = null, DateArchived = null, AmountCalories = 150
    union select 'cbeer', 'French', 'Apple Yogurt Smoothie', '10/10/12', '12/10/14', null, 75
    union select 'hlauer', 'English', 'Butter Muffin', '08/07/15', '11/04/15', '12/20/16', 120
    union select 'emorris', 'English', 'Cheese Bread', '10/14/2017', null, '10/25/18', 110
    union select 'rweinberg', 'English', 'Turkey Salad', '10/12/20', null, null, 75
    union select 'elauer', 'French', 'Shnitzel', '09/09/21', '09/09/23', null, 145
    union select 'ylauer', 'American', 'Potato Kugel', '01/01/21', null, '02/02/22', 135
)
insert Recipe(WebUserId, CuisineId, RecipeName, DateDrafted, DatePublished, DateArchived, AmountCalories)
select w.WebUserId, c.CuisineId, x.RecipeName, x.DateDrafted, x.DatePublished, x.DateArchived, x.AmountCalories
from x
join WebUser w
on w.WebUserName = x.WebUserName
join Cuisine c
on c.CuisineName = x.CuisineName
go

insert Ingredient(IngredientName)
select 'Sugar'
union select 'Oil'
union select 'Egg'
union select 'Flour'
union select 'Vanilla Sugar'
union select 'Baking Powder'
union select 'Baking Soda'
union select 'Chocolate Chips'
union select 'Granny Smith Apple'
union select 'Vanilla Yogurt'
union select 'Orange Juice'
union select 'Honey'
union select 'Ice Cube'
union select 'Butter'
union select 'Vanilla Pudding'
union select 'Whipped Cream Cheese'
union select 'Sour Cream Cheese'
union select 'Bread'
union select 'Shredded Cheese'
union select 'Garlic'
union select 'Black Pepper'
union select 'Salt'
union select 'Potato'
union select 'Chicken Cutlet'
union select 'Bread Crumb'
union select 'Turkey Chunk'
union select 'Cucumber'
union select 'Tomato'
union select 'Romaine Lettuce'
union select 'Onion'
go

Insert Measurement(MeasurementDesc)
select 'cup'
union select 'tsp'
union select 'tbsp'
union select 'stick'
union select 'oz'
union select 'club'
union select 'clove'
union select 'pinch'
union select 'lb'
union select 'pack'
go

;
with x as(
    select RecipeName = 'Chocolate Chip Cookies', IngredientName = 'Sugar', MeasurementName = 'cup', MeasurementAmount = 1, IngredientSequence = 1
    union select 'Chocolate Chip Cookies', 'Oil', 'cup', 0.5, 2
    union select 'Chocolate Chip Cookies', 'Egg', null, 3, 3
    union select 'Chocolate Chip Cookies', 'Flour', 'cup', 2, 4
    union select 'Chocolate Chip Cookies', 'Vanilla Sugar', 'tsp', 1, 5
    union select 'Chocolate Chip Cookies', 'Baking Powder', 'tsp', 2, 6
    union select 'Chocolate Chip Cookies', 'Baking Soda', 'tsp', 0.5, 7
    union select 'Chocolate Chip Cookies', 'Chocolate Chips', 'cup', 1, 8
    union select 'Apple Yogurt Smoothie', 'Granny Smith Apple', null, 3, 1
    union select 'Apple Yogurt Smoothie', 'Vanilla Yogurt', 'cup', 2, 2
    union select 'Apple Yogurt Smoothie', 'Sugar', 'tsp', 2, 3
    union select 'Apple Yogurt Smoothie', 'Orange Juice', 'cup', 0.5, 4
    union select 'Apple Yogurt Smoothie', 'Honey', 'tbsp', 2, 5
    union select 'Apple Yogurt Smoothie', 'Ice Cube', null, 5, 6
    union select 'Butter Muffin', 'Butter', 'stick', 1, 1
    union select 'Butter Muffin', 'Sugar', 'cup', 3, 2
    union select 'Butter Muffin', 'Vanilla Pudding', 'tbsp', 2, 3
    union select 'Butter Muffin', 'Egg', null, 4, 4
    union select 'Butter Muffin', 'Whipped Cream Cheese', 'oz', 8, 5
    union select 'Butter Muffin', 'Sour Cream Cheese', 'oz', 8, 6
    union select 'Butter Muffin', 'Flour', 'cup', 1, 7
    union select 'Butter Muffin', 'Baking Powder', 'tsp', 2, 8
    union select 'Cheese Bread', 'Bread', 'club', 1, 1
    union select 'Cheese Bread', 'Butter', 'oz', 4, 2
    union select 'Cheese Bread', 'Shredded Cheese', 'oz', 8, 3
    union select 'Cheese Bread', 'Garlic', 'Clove', 2, 4
    union select 'Cheese Bread', 'Black Pepper', 'tsp', 0.25, 5
    union select 'Cheese Bread', 'Salt', 'pinch', 1, 6
    union select 'Turkey Salad', 'Turkey Chunk', 'lb', 1, 1
    union select 'Turkey Salad', 'Romaine Lettuce', 'cup', 2, 2
    union select 'Turkey Salad', 'Tomato', null, 1, 3
    union select 'Turkey Salad', 'Cucumber', null, 1, 4
    union select 'Turkey Salad', 'Dressing', 'tbsp', 1, 5
    union select 'Potato Kugel', 'Potato', 'lb', 5, 1
    union select 'Potato Kugel', 'Onion', null, 1, 2
    union select 'Potato Kugel', 'Egg', null, 6, 3
    union select 'Potato Kugel', 'Oil', 'cup', 2, 4
    union select 'Potato Kugel', 'Salt', 'tsp', 2, 5
    union select 'Potato Kugel', 'Pepper', 'tsp', 2, 6
    union select 'Shnitzel', 'Chicken Cutlet', 'pack', 1, 1
    union select 'Shnitzel', 'Egg', null, 2, 2
    union select 'Shnitzel', 'Salt', 'tsp', 1, 3
    union select 'Shnitzel', 'Pepper', 'tsp', 1, 4
    union select 'Shnitzel', 'Garlic', 'tsp', 1, 5
    union select 'Shnitzel', 'Bread Crumb', 'cup', 2, 6
    union select 'Shnitzel', 'Oil', 'cup', 1, 7
)

Insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, MeasurementAmount, IngredientSequence)
select r.RecipeId, i.IngredientId, m.MeasurementId, x.MeasurementAmount, x.IngredientSequence
from x
join Recipe r
on x.RecipeName = r.RecipeName
join Ingredient i
on i.IngredientName = x.IngredientName
left join Measurement m
on m.MeasurementDesc = x.MeasurementName
go

;
with x as(
    select RecipeName = 'Chocolate Chip Cookies', RecipeSequence = 1, RecipeDirection = 'First combine sugar, oil, and eggs in a bowl'
    union select 'Chocolate Chip Cookies',  2, 'Mix well'
    union select 'Chocolate Chip Cookies',  3, 'Add flour, vanilla sugar, baking powder and baking soda'
    union select 'Chocolate Chip Cookies',  4, 'Beat for 5 minutes'
    union select 'Chocolate Chip Cookies',  5, 'Add chocolate chips'
    union select 'Chocolate Chip Cookies',  6, 'Freeze for 1-2 hours'
    union select 'Chocolate Chip Cookies',  7, 'Roll into balls and place spread out on a cookie sheet'
    union select 'Chocolate Chip Cookies',  8, 'Bake at 350 for 10 min.'
    union select 'Apple Yogurt Smoothie', 1, 'Peel the apples and dice'
    union select 'Apple Yogurt Smoothie', 2, 'Combine all ingredients in bowl except for apples and ice cubes'
    union select 'Apple Yogurt Smoothie', 3, 'Mix until smooth'
    union select 'Apple Yogurt Smoothie', 4, 'Add apples and ice cubes'
    union select 'Apple Yogurt Smoothie', 5, 'Pour into glasses'
    union select 'Butter Muffin', 1, 'Cream butter with sugars'
    union select 'Butter Muffin', 2, 'Add eggs and mix well'
    union select 'Butter Muffin', 3, 'Slowly add rest of ingredients and mix well'
    union select 'Butter Muffin', 4, 'Fill muffin pans 3/4 full and bake for 30 minutes.'
    union select 'Cheese Bread', 1, 'Slit bread every 3/4 inch'
    union select 'Cheese Bread', 2, 'Combine all ingredients in bowl'
    union select 'Cheese Bread', 3, 'Fill slits with cheese mixture'
    union select 'Cheese Bread', 4, 'Wrap bread into a foil and bake for 30 minutes.'
    union select 'Turkey Salad', 1, 'Cut up turkey chunks, tomato, and cucumber'
    union select 'Turkey Salad', 2, 'Add into lettuce'
    union select 'Turkey Salad', 3, 'Drizzle on dressing of your choice.'
    union select 'Potato Kugel', 1, 'Peel potatoes'
    union select 'Potato Kugel', 2, 'Mix together eggs, oil, salt, pepper'
    union select 'Potato Kugel', 3, 'Grate onion in s blade'
    union select 'Potato Kugel', 4, 'Grate potatoes in kugel blade'
    union select 'Potato Kugel', 5, 'Mix together'
    union select 'Potato Kugel', 6, 'Grease pan, bake at 350 for 1 hour'
    union select 'Shnitzel', 1, 'Thin chicken cutlets'
    union select 'Shnitzel', 2, 'Marinate cutlets with eggs, and spices'
    union select 'Shnitzel', 3, 'Bread the cutlets'
    union select 'Shnitzel', 4, 'Fry in oil until crispy'         
)

insert Direction(RecipeId, RecipeSequence, RecipeDirection)
select r.RecipeId, x.RecipeSequence, x.RecipeDirection
from x
join Recipe r
on r.RecipeName = x.RecipeName
go

;
with x as(
    select UserName = 'elauer', MealName = 'Breakfast Bash', DateCreated = '02/14/22', Active = 0
    union select 'ylauer', 'Lunch Special', '10/10/23', 1
    union select 'rweinberg', 'Supper Spectacular', '12/12/24', 1
    union select 'hlauer', 'Brunch to Munch', '11/11/24', 1
)
Insert Meal(WebUserId, MealName, DateMealCreated, Active)
select w.WebUserId, x.MealName, x.DateCreated, x.Active
from x
join WebUser w
on x.UserName = w.WebUserName
go

Insert Course(CourseName, CourseSequence)
select 'Appetizer', 1
union select 'Main', 2
union select 'Dessert', 3
go

;
with x as(
select Course = 'Main', Meal = 'Breakfast Bash'
union select 'Main', 'Brunch to Munch'
union select 'Appetizer', 'Lunch Special'
union select 'Main', 'Lunch Special'
union select 'Appetizer', 'Supper Spectacular'
union select 'Main', 'Supper Spectacular'
union select 'Dessert', 'Supper Spectacular'
)

insert CourseMeal(CourseId, MealId)
select c.CourseId, m.MealId
from x
join Course c
on x.Course = c.CourseName
join Meal m
on m.MealName = x.Meal
go

;
with x as(
    select Recipe = 'Cheese Bread', Course = 'Main', Meal = 'Breakfast Bash', CourseType = 1
    union select 'Apple Yogurt Smoothie', 'Main', 'Brunch to Munch', 1
    union select 'Butter Muffin', 'Appetizer', 'Lunch Special', 0
    union select 'Cheese Bread', 'Main', 'Lunch Special', 1
    union select 'Turkey Salad', 'Appetizer', 'Supper Spectacular', 0
    union select 'Shnitzel', 'Main', 'Supper Spectacular', 1
    union select 'Potato Kugel', 'Main', 'Supper Spectacular', 0
    union select 'Chocolate Chip Cookies', 'Dessert', 'Supper Spectacular', 0
)
insert RecipeCourseMeal(RecipeId, CourseMealId, CourseType)
select r.RecipeId, cm.CourseMealId, x.CourseType
from x
join Recipe r
on x.Recipe = r.RecipeName
join Course o
on x.Course = o.CourseName
join Meal m
on m.MealName = x.Meal
join CourseMeal cm
on cm.CourseId = o.CourseId and cm.MealId = m.MealId
go

insert CookBook(WebUserId, CookBookName, CookBookPrice, DateCookBookCreated, Active)
select (select w.WebUserId from WebUser w where w.WebUserName = 'mlauer'), 'Treats for Two', 30, '01/12/20', 0
union select (select w.WebUserId from WebUser w where w.WebUserName = 'hlauer'), 'Health Nut', 25, '01/22/21', 1
union select (select w.WebUserId from WebUser w where w.WebUserName = 'hlauer'), 'Food for Thought', 22, '09/18/24', 1
union select (select w.WebUserId from WebUser w where w.WebUserName = 'hlauer'), 'Ready for Shabbos', 40, '08/05/22', 1
go

;
with x as(
    select Recipe = 'Chocolate Chip Cookies', CookBook = 'Treats for Two', RecipeSequence = 1
    union select 'Apple Yogurt Smoothie', 'Treats for Two', 2
    union select 'Cheese Bread', 'Treats for Two', 3
    union select 'Butter Muffin', 'Treats for Two', 4
    union select 'Apple Yogurt Smoothie', 'Health Nut', 1
    union select 'Turkey Salad', 'Health Nut', 2
    union select 'Cheese Bread', 'Food for Thought', 1
    union select 'Butter Muffin', 'Food for Thought', 2
    union select 'Potato Kugel', 'Food for Thought', 3
    union select 'Shnitzel', 'Ready for Shabbos', 1
    union select 'Potato Kugel', 'Ready for Shabbos', 2
    union select 'Chocolate Chip Cookies', 'Ready for Shabbos', 3

)
insert RecipeCookBook(RecipeId, CookBookId, RecipeSequence)
select r.RecipeId, b.CookBookId, x.RecipeSequence
from x
join Recipe r
on x.Recipe = r.RecipeName
join CookBook b
on b.CookBookName = x.CookBook
go

select * from Cuisine
select * from WebUser
select * from Recipe
select * from Ingredient
select * from Measurement
select * from RecipeIngredient
select * from Direction
select * from Meal
select * from Course
select * from CourseMeal
select * from RecipeCourseMeal
select * from CookBook
select * from RecipeCookBook







