create or alter procedure dbo.CookbookGet(
	@CookbookId int = 0,
	@CookbookName varchar(50) = '',
	@All bit = 0,
	@IncludeBlank bit = 0
	)
as
begin
	select @CookbookName = nullif(@CookbookName, ''), @IncludeBlank = isnull(@IncludeBlank, 0)
	select cb.CookbookId, cb.WebUserId, cb.CookbookName, cb.CookbookPrice, cb.DateCookbookCreated, cb.Active
	from Cookbook cb
	where cb.CookbookId = @CookbookId
	or @All = 1
	or cb.CookbookName like '%' + @CookbookName + '%'
	union select 0, 0, ' ', 0, null, 0
	where @IncludeBlank = 1
	order by cb.CookBookName
end
go

exec CookbookGet

exec CookbookGet @All = 1

declare @id int
select top 1 @id = cb.CookbookId from Cookbook cb
exec CookbookGet @CookbookId = @id

exec CookbookGet @CookbookName = 'food'

exec CookbookGet @CookbookName = null

exec CookbookGet @CookbookName = ''