use HeartyHearthDB
go

create or alter procedure dbo.RecipeIngredientDelete(
    @RecipeIngredientId int = 0,
    @Message varchar(500) = '' output
)

as
begin
    declare @return int = 0

    select @RecipeIngredientId = isnull(@RecipeIngredientId, 0)

    delete RecipeIngredient where RecipeIngredientId = @RecipeIngredientId

        ;
    with x as
        (
            select IngredientId,
            NewSequence = ROW_NUMBER() over (partition by RecipeId order by IngredientSequence, IngredientId)
            from RecipeIngredient ri
        )
            update ri
            set 
                IngredientSequence = x.NewSequence
            from RecipeIngredient ri
            join x
            on x.IngredientId = ri.IngredientId

    return @return
end
go

