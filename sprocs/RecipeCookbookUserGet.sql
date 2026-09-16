use HeartyHearthDB
go

create proc RecipeCookBookUserGet(
    @WebUserId int output,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0
    select 
        r.RecipeId,
        r.WebUserId,
        r.RecipeName,
        RecipeSequence = row_number() over (order by r.RecipeName),
        CookBookName = concat('Recipes by ', w.WebUserFirstName, ' ', w.WebUserLastName),
        Price = count(*) over () * 1.33
    from Recipe r
    join WebUser w
    on w.WebUserId = r.WebUserId
    where r.WebUserId = @WebUserId
    order by r.RecipeName

    return @return
end
go


