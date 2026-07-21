create or alter procedure dbo.WebUserGet(@WebUserId int = 0, @All bit = 0, @WebUserName varchar(50) = '')
as
begin
	select @WebUserName = nullif(@WebUserName , '')
	select w.WebUserId, w.WebUserFirstName, w.WebUserLastName, w.WebUserName
	from WebUser w
	where w.WebUserId = @WebUserId
	or @All = 1
	or w.WebUserName like '%' + @WebUserName + '%'
end
go

exec WebUserGet

exec WebUserGet @All = 1

declare @id int
select top 1 @id = w.WebUserId from WebUser w
exec WebUserGet @WebUserId = @id

exec WebUserGet @WebUserName = 'h'

exec WebUserGet @WebUserName = null

exec WebUserGet @WebUserName = ''
