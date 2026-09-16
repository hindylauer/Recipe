create or alter procedure dbo.MealGet(@MealId int = 0, @All bit = 0, @MealName varchar(35) = '', @IncludeBlank bit = 0)
as
begin
	select @MealName = nullif(@MealName, ''), @IncludeBlank = isnull(@IncludeBlank, 0)
	select m.MealId, m.WebUserId, m.MealName, m.DateMealCreated, Active
	from Meal m
	where m.MealId = @MealId
	or @All = 1
	or m.MealName like '%' + @MealName + '%'
	union select 0, 0, ' ', null, 0
	where @IncludeBlank = 1
	order by m.MealName
end
go

exec MealGet

exec MealGet @All = 1

declare @id int
select top 1 @id = m.MealId from Meal m
exec MealGet @MealId = @id

exec MealGet @MealName = 'b'

exec MealGet @MealName = null

exec MealGet @MealName = ''