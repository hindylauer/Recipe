use HeartyHearthDB
go

create or alter procedure dbo.DirectionGet(
	@DirectionId int = 0,
	@RecipeId int = 0,
	@All bit = 0,
	@IncludeBlank bit = 0,
	@Message varchar(500) = '' output) 
as
begin
	select @IncludeBlank = isnull(@IncludeBlank, 0)

	select d.DirectionId, d.RecipeId, d.RecipeSequence, d.RecipeDirection
	from Direction d
	where d.DirectionId = @DirectionId
	or d.RecipeId = @RecipeId
	or @All = 1
	union select 0, 0, 0, ' '
	where @IncludeBlank = 1
	order by d.RecipeSequence
end
go

exec DirectionGet

exec DirectionGet @All = 1

declare @id int
select top 1 @id = d.DirectionId from Direction d
exec DirectionGet @DirectionId = @id


select * from direction