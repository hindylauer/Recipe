use HeartyHearthDB
go

create or alter procedure dbo.DirectionUpdate(
    @DirectionId int output,
    @RecipeId int,
    @RecipeSequence int,
    @RecipeDirection varchar(150),
    @Message varchar(500) = output
)
as
begin
    declare @return int = 0

    select @DirectionId = isnull(@DirectionId, 0)

    if @DirectionId = 0
    begin
        insert Direction(RecipeId, RecipeSequence, RecipeDirection)
        values(@RecipeId, @RecipeSequence, @RecipeDirection)

        select @DirectionId = SCOPE_IDENTITY()

    end
    else
    begin
        update Direction
        set
        RecipeId = @RecipeId,
        RecipeSequence = @RecipeSequence,
        RecipeDirection = @RecipeDirection
        where DirectionId = @DirectionId
    end

    return @return

    end
    go

select * from Direction