use HeartyHearthDB
go

create or alter proc dbo.RecipeCookBookUpdate(
    @RecipeCookbookId int output,
    @RecipeId int,
    @CookbookId int,
    @RecipeSequence int,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0
    select @RecipeCookbookId = isnull(@RecipeCookbookId, 0)

    if exists
    (
        select *
        from RecipeCookbook rc
        where rc.CookbookId = @CookbookId
        and rc.RecipeSequence = @RecipeSequence
        and rc.RecipeCookbookId <> @RecipeCookbookId
    )
    begin
        set @Message = 'Recipe sequence numbers must be unique.'
        return 1
    end

    if @RecipeCookbookId = 0
    begin
        insert RecipeCookBook(RecipeId, CookBookId, RecipeSequence)
        values(@RecipeId, @CookbookId, @RecipeSequence)
    
    select @RecipeCookbookId = SCOPE_IDENTITY()
    end
    else
    begin
        update RecipeCookBook
        set
            RecipeId = @RecipeId,
            CookBookId = @CookbookId,
            RecipeSequence = @RecipeSequence
        where RecipeCookBookId = @RecipeCookbookId    
    end

    return @return
end
go