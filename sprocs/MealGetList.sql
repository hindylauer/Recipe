create or alter procedure dbo.MealGetList(
    @Message varchar(500)  = '' output
    )
as
begin
		select MealId = m.MealId, MealName = m.MealName, WebUser = w.WebUserName,  NumCalories = sum(r.AmountCalories), NumCourses =  count(distinct cm.CourseId), NumRecipes =  count(distinct r.RecipeId)
		from Meal m
        join WebUser w
        on w.WebUserId = m.WebUserId
        join CourseMeal cm
        on cm.MealId = m.MealId
        join RecipeCourseMeal rcm
        on rcm.CourseMealId = cm.CourseMealId
        join Recipe r
        on r.RecipeId = rcm.RecipeId
        group by m.MealId, m.MealName, w.WebUserName
        order by m.MealName
end
go

exec MealGetList
