declare @return int, @recipeid int,
@WebUserId int,
@CuisineId int,
@RecipeName varchar(50),
@DateDrafted datetime,
@DatePublished datetime,
@DateArchived datetime,
@AmountCalories int

select top 1 
@RecipeId = r.recipeid,
@WebUserId = r.webuserid,
@CuisineId = r.cuisineid,
@RecipeName = r.recipename,
@DateDrafted = r.datedrafted,
@DatePublished = r.DatePublished,
@DateArchived = r.DateArchived,
@AmountCalories = r.AmountCalories
from Recipe r

select @RecipeName = reverse(@RecipeName)

exec @return = RecipeUpdate
@RecipeId = @RecipeId output,
@WebUserId = @webuserid,
@CuisineId = @cuisineid,
@RecipeName = @recipename,
@DateDrafted = @datedrafted,
@DatePublished = @DatePublished,
@DateArchived = @DateArchived,
@AmountCalories = @AmountCalories

select @return, @recipeid

select * from recipe r where RecipeId = @RecipeId