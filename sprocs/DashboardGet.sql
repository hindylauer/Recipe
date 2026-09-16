create or alter proc dbo.DashboardGet(
	@Message varchar(500) = '' output
)
as
begin
	declare @return int = 0

	select  DashboardType = 'Recipes', Num = (select count(r.RecipeId)) from Recipe r
	union select  DashboardType = 'Meals', (select count(m.MealId)) from Meal m
    union select  DashboardType = 'Cookbooks', (select count(c.CookbookId)) from Cookbook c

	return @return
end
go
Exec DashboardGet

