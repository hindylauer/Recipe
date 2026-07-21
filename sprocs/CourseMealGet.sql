create or alter procedure dbo.CourseMealGet(@CourseMealId int = 0, @All bit = 0, @MealId int = null)
as
begin
	select cm.CourseId, cm.CourseId, cm.MealId
	from CourseMeal cm
	where cm.CourseMealId = @CourseMealId
	or @All = 1
	or cm.MealId = @MealId
end
go

exec CourseMealGet

exec CourseMealGet @All =1

declare @id int
select top 1 @id = cm.CourseMealId from CourseMeal cm
exec CourseMealGet @CourseMealId = @id

exec CourseMealGet @MealId = 6

exec CourseMealGet @MealId = null