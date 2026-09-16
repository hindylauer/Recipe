create or alter procedure dbo.CuisineGet(@CuisineId int = 0, @All bit = 0, @CuisineName varchar(50) = '', @IncludeBlank bit = 0)
as
begin
	select @CuisineName = nullif(@CuisineName, ''), @IncludeBlank = isnull(@IncludeBlank, 0)
	select c.CuisineId, c.CuisineName
	from Cuisine c
	where c.CuisineId = @CuisineId
	or @All = 1
	or c.CuisineName like '%' + @CuisineName + '%'
	union select 0, ''
	where @IncludeBlank = 1
	order by c.CuisineName
end
go

exec CuisineGet

exec CuisineGet @All = 1

declare @id int
select top 1 @id = c.CuisineId from Cuisine c
exec CuisineGet @CuisineId = @id

exec CuisineGet @CuisineName = 'a'

exec CuisineGet @CuisineName = null

exec CuisineGet @CuisineName = ''


