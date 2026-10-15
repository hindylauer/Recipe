use HeartyHearthDB
go
--select concat('grant execute on ', r.ROUTINE_Name, ' to approle')
--from INFORMATION_SCHEMA.ROUTINES r

grant execute on CuisineGet to approle
grant execute on RecipeIngredientGet to approle
grant execute on CookBookGet to approle
grant execute on CourseGet to approle
grant execute on CourseMealGet to approle
grant execute on DirectionGet to approle
grant execute on IngredientGet to approle
grant execute on MealGet to approle
grant execute on MeasurementGet to approle
grant execute on RecipeCookBookGet to approle
grant execute on RecipeCourseMealGet to approle
grant execute on RecipeGet to approle
grant execute on CusineGet to approle