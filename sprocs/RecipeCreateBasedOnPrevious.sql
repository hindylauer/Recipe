use HeartyHearthDB
go

create or alter proc dbo.RecipeCreateBasedOnPrevious(
    @RecipeId int = null output,
    @BaseRecipeId int,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    insert Recipe(WebUserId, CuisineId, RecipeName, DateDrafted, DatePublished, DateArchived, AmountCalories)
    select r.WebUserId, r.CuisineId, r.RecipeName + ' - clone', r.DateDrafted, null, null, r.AmountCalories
    from Recipe r
    where r.RecipeId = @BaseRecipeId

    select @RecipeId = SCOPE_IDENTITY()

    insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, MeasurementAmount, IngredientSequence)
    select @RecipeId, ri.IngredientId, ri.MeasurementId, ri.MeasurementAmount, ri.IngredientSequence
    from RecipeIngredient ri
    where ri.RecipeId = @BaseRecipeId

    insert Direction(RecipeId, RecipeSequence, RecipeDirection)
    select @RecipeId, d.RecipeSequence, d.RecipeDirection
    from Direction d
    where d.RecipeId = @BaseRecipeId

    return @return
end
go


