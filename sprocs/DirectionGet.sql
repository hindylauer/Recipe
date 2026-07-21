create or alter procedure dbo.DirectionGet(@DirectionId int = 0, @All bit = 0, @RecipeDirection varchar(150) = '') 
as
begin
	select @RecipeDirection = nullif(@RecipeDirection, '')
	select d.DirectionId, d.RecipeId, d.RecipeSequence, d.RecipeDirection
	from Direction d
	where d.DirectionId = @DirectionId
	or @All = 1
	or d.RecipeDirection like '%' + @RecipeDirection + '%'
end
go

exec DirectionGet

exec DirectionGet @All = 1

declare @id int
select top 1 @id = d.DirectionId from Direction d
exec DirectionGet @DirectionId = @id

exec DirectionGet @RecipeDirection = 'Pour'

exec DirectionGet @RecipeDirection = null

exec DirectionGet @RecipeDirection = ''