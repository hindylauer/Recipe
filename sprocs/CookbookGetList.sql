create or alter procedure dbo.CookbookGetList(
    @Message varchar(500) = '' output
)
as
begin
    select c.CookbookId, c.CookbookName, Author = concat(w.WebUserFirstName, ' ', w.WebUserLastName), NumRecipes = count(rc.RecipeId), c.CookbookPrice
    from Cookbook c
    left join WebUser w
    on w.WebUserId = c.WebUserId
    left join RecipeCookbook rc
    on rc.CookbookId = c.CookbookId
    group by c.CookbookId, c.CookbookName, w.WebUserFirstName, w.WebUserLastName, c.CookbookPrice
    order by c.CookbookName
end
go

exec CookbookGetList
