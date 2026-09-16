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

    return @return
end
go