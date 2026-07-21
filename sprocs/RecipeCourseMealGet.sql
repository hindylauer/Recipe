create or alter procedure dbo.RecipeCourseMealGet(@RecipeCourseMealId int = 0, @All bit = 0, @CourseType int = null)
as
begin
	select rcm.RecipeCourseMealId, rcm.RecipeId, rcm.CourseMealId, rcm.CourseType
	from RecipeCourseMeal rcm
	where rcm.RecipeCourseMealId = @RecipeCourseMealId
	or @All = 1
	or rcm.CourseType = @CourseType
end
go

exec RecipeCourseMealGet

exec RecipeCourseMealGet @All = 1

declare @id int
select top 1 @id = rcm.RecipeCourseMealId from RecipeCourseMeal rcm
exec RecipeCourseMealGet @RecipeCourseMealId = @id

exec RecipeCourseMealGet @CourseType = 1

exec RecipeCourseMealGet @CourseType = null

