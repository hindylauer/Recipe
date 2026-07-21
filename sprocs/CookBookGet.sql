create or alter procedure dbo.CookBookGet(@CookBookId int = 0, @All bit = 0, @CookBookName varchar(50) = '')
as
begin
	select @CookBookName = nullif(@CookBookName, '')
	select cb.CookBookId, cb.WebUserId, cb.CookBookName, cb.CookBookPrice, cb.DateCookBookCreated, cb.Active, cb.CookBookImage
	from CookBook cb
	where cb.CookBookId = @CookBookId
	or @All = 1
	or cb.CookBookName like '%' + @CookBookName + '%'
end
go

exec CookBookGet

exec CookBookGet @All = 1

declare @id int
select top 1 @id = cb.CookBookId from CookBook cb
exec CookBookGet @CookBookId = @id

exec CookBookGet @CookBookName = 'food'

exec CookBookGet @CookBookName = null

exec CookBookGet @CookBookName = ''