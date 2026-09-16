use HeartyHearthDB
go

create or alter proc dbo.CookbookUpdate(
    @CookbookId int output,
    @WebUserId int,
    @CookbookName varchar(50),
    @CookBookPrice decimal(10,2),
    @DateCookbookCreated datetime,
    @Active bit

)

as
begin
    declare @return int = 0

    select @CookbookId = isnull(@CookbookId, 0)

    if @CookbookId = 0
    begin
        insert CookBook(WebUserId, CookBookName, CookBookPrice, DateCookBookCreated, Active)
        values(@WebUserId, @CookbookName, @CookBookPrice, @DateCookbookCreated, @Active)

        select @CookbookId = SCOPE_IDENTITY()
    end

    else
    begin
        Update CookBook
        set
            WebUserId = @WebUserId,
            CookBookName = @CookbookName,
            CookBookPrice = @CookBookPrice,
            DateCookBookCreated = @DateCookbookCreated,
            Active = @Active
            where CookBookId = @CookbookId
    end

    return @return
end
    go

