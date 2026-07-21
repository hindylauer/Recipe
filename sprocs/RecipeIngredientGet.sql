create or alter procedure dbo.RecipeIngredientGet(@RecipeIngredientId int = 0, @All bit = 0, @IngredientSequence int = null)
as
begin
	select ri.RecipeIngredientId, ri.RecipeId, ri.IngredientId, ri.MeasurementId, ri.MeasurementAmount, ri.IngredientSequence
	from RecipeIngredient ri
	where ri.RecipeIngredientId = @RecipeIngredientId
	or @All = 1
	or ri.IngredientSequence = ri.IngredientSequence
end
go


exec RecipeIngredientGet

exec RecipeIngredientGet @All = 1

declare @id int
select top 1 @id = ri.RecipeIngredientId from RecipeIngredient ri
exec RecipeIngredientGet @RecipeINgredientId = @id

exec RecipeIngredientGet @IngredientSequence = 1

exec RecipeIngredientGet @IngredientSequence = null



