create or alter procedure dbo.RecipeCookBookGet(@RecipeCookBookId int = 0, @All bit = 0, @RecipeSequence int = null)
as
begin
	select rcb.RecipeCookBookId, rcb.RecipeId, rcb.CookBookId, rcb.RecipeSequence
	from RecipeCookBook rcb
	where rcb.RecipeCookBookId = @RecipeCookBookId
	or @All = 1
	or rcb.RecipeSequence = @RecipeSequence
end
go

exec RecipeCookBookGet

exec RecipeCookBookGet @All = 1

declare @id int
select top 1 @id = rcb.RecipeCookBookId from RecipeCookBook rcb
exec RecipeCookBookGet @RecipeCookBookId = @id

exec RecipeCookBookGet @RecipeSequence = 1

exec RecipeCookBookGet @RecipeSequence = null