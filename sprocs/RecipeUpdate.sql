create or alter proc dbo.RecipeUpdate(

@RecipeId int output,
@WebUserId int,
@CuisineId int,
@RecipeName varchar(50),
@DateDrafted datetime,
@DatePublished datetime,
@DateArchived datetime,
@AmountCalories int
)
as
begin
    declare @return int = 0

    select @RecipeId = isnull(@RecipeId, 0)

    if @RecipeId = 0
    begin
        insert Recipe(WebUserId, CuisineId, RecipeName, DateDrafted, DatePublished, DateArchived, AmountCalories)
        values(@WebUserId, @CuisineId, @RecipeName, @DateDrafted, @DatePublished, @DateArchived, @AmountCalories)

        select @RecipeId = scope_identity()
    end
    else
    begin
        update Recipe
        set
            WebUserId = @WebUserId, 
            CuisineId = @CuisineId, 
            RecipeName = @RecipeName, 
            DateDrafted = @DateDrafted, 
            DatePublished = @DatePublished, 
            DateArchived = @DateArchived,
            AmountCalories = @AmountCalories
            where RecipeId = @RecipeId
        end

        return @return
end
go

