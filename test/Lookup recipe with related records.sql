declare @recipeid int

select @recipeid = r.RecipeId from Recipe r

select @recipeid

select r.RecipeId from recipe r where r.RecipeId = @recipeid
union select d.DirectionId from direction d where d.RecipeId = @recipeid
union select ri.RecipeId from RecipeIngredient ri where ri.RecipeId = @recipeid