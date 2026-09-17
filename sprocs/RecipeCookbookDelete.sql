use HeartyHearthDB
go

create or alter proc dbo.RecipeCookBookDelete(
    @RecipeCookbookId int,
    @Message varchar(500) = ''
)
as
begin
    declare @return int = 0
    select @RecipeCookbookId = isnull(@RecipeCookbookId, 0)

    delete RecipeCookBook where RecipeCookBookId = @RecipeCookbookId

    ;
    with x as
    (
        select
            RecipeCookbookId,
            NewSequence = row_number() over
            (
                partition by CookbookId
                order by RecipeSequence, RecipeCookbookId
            )
        from RecipeCookbook
    )
    update rc
    set 
        RecipeSequence = x.NewSequence
    from RecipeCookbook rc
    join x
        on x.RecipeCookbookId = rc.RecipeCookbookId

    return @return
end
go