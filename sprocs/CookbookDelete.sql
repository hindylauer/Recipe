use HeartyHearthDB
go

create proc dbo.CookbookDelete(
    @CookbookId int output,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0
    
    select @CookbookId = isnull(@CookbookId, 0)
    delete CookBook where CookBookId = @CookbookId

    return @return
end
go