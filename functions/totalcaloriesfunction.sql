create or alter function dbo.GetMealCalories(@MealId int)
returns int
as
begin
    declare @value int = 0
    select @value = (sum(r.AmountCalories))
    from Meal m
    join CourseMeal cm
    on cm.MealId = m.MealId
    join RecipeCourseMeal rcm
    on rcm.CourseMealId = cm.CourseMealId
    join Recipe r
    on r.RecipeId = rcm.RecipeId
    where m.MealId = @MealId

    return @value
end
go

select AmountCaloriesPerMeal = dbo.GetMealCalories(1)



