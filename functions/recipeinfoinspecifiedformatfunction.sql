create or alter function dbo.RecipeInfo(@RecipeId int)
returns varchar(130)
as
begin
    declare @value varchar(130) = ''
    select @value = concat(
        r.RecipeName,
        ' (',
        c.CuisineName,
        ') has ',
        count(distinct ri.IngredientSequence),
        ' ingredients and ',
        count(distinct d.RecipeSequence),
        ' steps.'
        )
    from recipe r
    left join cuisine c
    on c.CuisineId = r.CuisineId
    left join RecipeIngredient ri
    on ri.RecipeId = r.RecipeId
    left join Direction d
    on d.RecipeId = r.RecipeId
    where @RecipeId = r.RecipeId
    group by r.RecipeName, c.CuisineName
    return @value
end
go

select RecipeInfo = dbo.RecipeInfo(7)