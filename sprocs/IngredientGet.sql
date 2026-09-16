use HeartyHearthDB
go
create or alter procedure dbo.IngredientGet(@IngredientId int = 0, @All bit = 0, @IngredientName varchar(30) = '', @IncludeBlank bit = 0)
as
begin
	select @IngredientName = nullif(@IngredientName, ''), @IncludeBlank = isnull(@IncludeBlank, 0)
	select i.IngredientId, i.IngredientName
	from Ingredient i
	where i.IngredientId = @IngredientId
	or @All = 1
	or i.IngredientName like '%' + @IngredientName + '%'
	union select 0, ' '
	where @IncludeBlank = 1
	order by i.IngredientName 
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