use HeartyHearthDB
go

create or alter proc dbo.WebUserUpdate(
    @WebUserId int output,
    @WebUserFirstName varchar(50),
    @WebUserLastName varchar(50),
    @WebUserName varchar(50),
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    select @WebUserId = isnull(@WebUserId, 0)

    if @WebUserId = 0
    begin
        insert WebUser(WebUserFirstName, WebUserLastName, WebUserName)
        values(@WebUserFirstName, @WebUserLastName, @WebUserName)

        select @WebUserId = scope_identity()
    end
    else
    begin
        update WebUser
        set
            WebUserFirstName = @WebUserFirstName,
            WebUserLastName = @WebUserLastName,
            WebUserName = @WebUserName
            where WebUserId = @WebUserId
        end

        return @return
end
go


