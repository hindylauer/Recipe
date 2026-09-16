use HeartyHearthDB
go

create or alter proc dbo.RecipeCookbookGet(
    @CookbookId int,
    @IncludeBlank bit = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0
    select @CookbookId = isnull(@CookbookId, 0)
    select rc.RecipeCookBookId, r.RecipeName, rc.RecipeId, rc.CookBookId, rc.RecipeSequence
    from RecipeCookBook rc
    left join Recipe r
    on r.RecipeId = rc.RecipeId
    where rc.CookBookId = @CookbookId
    union select 0, ' ', 0, 0, 0
    where @IncludeBlank = 1
    order by RecipeSequence, RecipeName
end
go




