use HeartyHearthDB
go
create or alter proc dbo.RecipeGetList(
    @Message varchar(500)  = '' output
    )
as
begin
        declare @return int = 0
		select 
            r.RecipeId,
            r.RecipeName,
            r.RecipeStatus,
            w.WebUserName,
            r.AmountCalories,
            NumIngredients = count(ri.IngredientSequence)
		from Recipe r
        left join WebUser w
        on w.WebUserId = r.WebUserId
        left join RecipeIngredient ri
        on ri.RecipeId = r.RecipeId
        group by r.RecipeId, r.RecipeName, r.RecipeStatus, w.WebUserName, r.AmountCalories
        order by r.RecipeStatus desc

        return @return
end
go

exec RecipeListGet


