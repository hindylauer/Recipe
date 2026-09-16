use HeartyHearthDB
go

create or alter proc dbo.CuisineDelete(
    @CuisineId int output,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    select @CuisineId = isnull(@CuisineId, 0)

begin try
    begin transaction

    delete rcm
    from RecipeCourseMeal rcm
    join Recipe r
    on r.RecipeId = rcm.RecipeId
    where r.CuisineId = @CuisineId

    delete rc
    from RecipeCookbook rc
    join Recipe r
    on r.RecipeId = rc.RecipeId
    where r.CuisineId = @CuisineId

    delete ri
    from RecipeIngredient ri
    join Recipe r 
    on r.RecipeId = ri.RecipeId
    where r.CuisineId = @CuisineId

    delete d
    from Direction d
    join Recipe r
    on r.RecipeId = d.RecipeId
    where r.CuisineId = @CuisineId

    delete r
    from Recipe r
    where r.CuisineId = @CuisineId

    delete c
    from Cuisine c
    where c.CuisineId = @CuisineId

    commit transaction
end try
begin catch
    rollback transaction
    throw
end catch

    return @return
    
end
go
