use HeartyHearthDB
go

create or alter proc dbo.IngredientDelete(
    @IngredientId int output,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    select @IngredientId = isnull(@IngredientId, 0)

begin try
    begin transaction

    delete ri
    from RecipeIngredient ri
    where ri.IngredientId = @IngredientId

    delete i
    from Ingredient i
    where i.IngredientId = @IngredientId



    commit transaction
end try
begin catch
    rollback transaction
    throw
end catch
    return @return

end
go

    
