use HeartyHearthDB
go

create or alter procedure dbo.RecipeGet(
	@RecipeId int = 0,
	@All bit = 0,
	@RecipeName varchar(50) = '',
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output
	)
as
begin
		declare @return int = 0
		select @RecipeName = nullif(@RecipeName, ''), @IncludeBlank = isnull(@IncludeBlank, 0)

		select
			r.RecipeId,
			r.WebUserId,
			r.CuisineId,
			r.RecipeName,
			r.DateDrafted,
			r.DatePublished,
			r.DateArchived,
			r.RecipeStatus,
			r.AmountCalories,
			w.WebUserName,
			NumIngredients = count(ri.IngredientSequence)
		from Recipe r
		left join WebUser w
		on w.WebUserId = r.WebUserId
		left join RecipeIngredient ri
		on ri.RecipeId = r.RecipeId
		where r.RecipeId = @RecipeId
		or @All = 1
		or r.RecipeName like '%' + @RecipeName + '%'
		group by
        r.RecipeId,
        r.WebUserId,
        r.CuisineId,
        r.RecipeName,
        r.DateDrafted,
        r.DatePublished,
        r.DateArchived,
        r.RecipeStatus,
        r.AmountCalories,
        w.WebUserName
		union select 0, 0, 0, ' ', null, null, null, ' ', 0, '', 0
		where @IncludeBlank = 1
		order by r.RecipeName

		return @return
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


use HeartyHearthDB
go

exec sp_help 'dbo.RecipeGet'