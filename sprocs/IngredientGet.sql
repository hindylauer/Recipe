create or alter procedure dbo.IngredientGet(@IngredientId int = 0, @All bit = 0, @IngredientName varchar(30) = '')
as
begin
	select @IngredientName = nullif(@IngredientName, '')
	select i.IngredientId, i.IngredientName, i.IngredientImage
	from Ingredient i
	where i.IngredientId = @IngredientId
	or @All = 1
	or i.IngredientName like '%' + @IngredientName + '%'
end
go

exec IngredientGet

exec IngredientGet @All = 1

declare @id int
select top 1 @id = i.IngredientId from Ingredient i
exec IngredientGet @IngredientId = @id

exec IngredientGet @IngredientName = 'r'

exec IngredientGet @IngredientName = 'baking'

exec IngredientGet @IngredientName = null

exec IngredientGet @IngredientName = ''