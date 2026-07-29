declare @recipeid int

select top 1 @recipeid = r.RecipeId
from recipe r
join Direction d
on r.RecipeId = d.RecipeId
join RecipeIngredient ri
on r.RecipeId = ri.RecipeId
order by r.RecipeId

select 'recipe', r.RecipeId, r.RecipeName from recipe r where r.recipeid = @recipeid
union select 'direction', d.DirectionId, d.RecipeDirection from Direction d where d.RecipeId = @recipeid
union select 'recipeingredient', ri.RecipeIngredientId, i.IngredientName  from RecipeIngredient ri left join Ingredient i on i.IngredientId = ri.IngredientId where ri.RecipeId = @recipeid

