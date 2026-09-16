use HeartyHearthDB
go

create or alter procedure dbo.RecipeIngredientGet(
	@RecipeIngredientId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = output
	)
as
begin
	declare @return int = 0

	select @IncludeBlank = isnull(@IncludeBlank, 0)

	select ri.RecipeIngredientId, ri.RecipeId, ri.IngredientId,  i.IngredientName, ri.MeasurementId, m.MeasurementDesc, ri.MeasurementAmount, ri.IngredientSequence
	from RecipeIngredient ri
	left join Ingredient i
	on i.IngredientId = ri.IngredientId
	left join Measurement m
	on m.MeasurementId = ri.MeasurementId
	where ri.RecipeIngredientId = @RecipeIngredientId
	or ri.RecipeId = @RecipeId
	or @All = 1
	union select 0, 0, 0, ' ', 0, ' ', 0, 0
	where @IncludeBlank = 1
	order by ri.IngredientSequence
	return @return
end
go


exec RecipeIngredientGet

exec RecipeIngredientGet @All = 1

declare @id int
select top 1 @id = ri.RecipeIngredientId from RecipeIngredient ri
exec RecipeIngredientGet @RecipeINgredientId = @id


select * from RecipeIngredient

