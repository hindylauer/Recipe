use HeartyHearthDB
go

create or alter proc dbo.WebUserDelete(
    @WebUserId int output,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    select @WebUserId = isnull(@WebUserId, 0)

begin try
    begin transaction

    delete rcm
    from RecipeCourseMeal rcm
    left join Recipe r
    on r.RecipeId = rcm.RecipeId
    left join CourseMeal cm
    on cm.CourseMealId = rcm.CourseMealId
    left join Meal m
    on m.MealId = cm.MealId
    where m.WebUserId = @WebUserId
    or r.WebUserId = @WebUserId  

    delete ri
    from RecipeIngredient ri
    join Recipe r
    on r.RecipeId = ri.RecipeId
    where r.WebUserId = @WebUserId

    delete d
    from Direction d
    join Recipe r
    on r.RecipeId = d.RecipeId
    where r.WebUserId = @WebUserId

    delete rc
    from RecipeCookbook rc
    left join Recipe r 
    on r.RecipeId = rc.RecipeId
    left join Cookbook c
    on c.CookbookId = rc.CookbookId
    where c.WebUserId = @WebUserId
    or r.WebUserId = @WebUserId
    

    delete cm
    from CourseMeal cm
    join Meal m
    on m.MealId = cm.MealId
    where m.WebUserId = @WebUserId

    delete r
    from Recipe r
    where r.WebUserId = @WebUserId

    delete c
    from Cookbook c
    where c.WebUserId = @WebUserId

    delete m
    from Meal m
    where m.WebUserId = @WebUserId

    delete w
    from WebUser w
    where w.WebUserId = @WebUserId

    commit transaction
end try
begin catch
    rollback transaction
    throw
    end catch

    return @return
end
go

