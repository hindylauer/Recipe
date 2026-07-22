create or alter procedure dbo.RecipeGet(@RecipeId int = 0, @All bit = 0, @RecipeName varchar(50) = '')
as
begin
		select @RecipeName = nullif(@RecipeName, '')
		select r.RecipeId, r.WebUserId, r.CuisineId, r.RecipeName, r.DateDrafted, r.DatePublished, r.DateArchived, r.RecipeStatus, r.AmountCalories, r.RecipeImage
		from Recipe r
		where r.RecipeId = @RecipeId
		or @All = 1
		or r.RecipeName like '%' + @RecipeName + '%'
end
go

exec RecipeGet

exec RecipeGet @All = 1

declare @id int
select top 1 @id = r.RecipeId from Recipe r
exec RecipeGet @RecipeId = @id

exec RecipeGet @RecipeName = 'b'

exec RecipeGet @RecipeName = null

exec RecipeGet @RecipeName = ''

select *
from sys.procedures
where name = 'RecipeGet';

select
    ServerName = @@SERVERNAME,
    DatabaseName = DB_NAME(),
    ProcedureId = OBJECT_ID('dbo.RecipeGet');