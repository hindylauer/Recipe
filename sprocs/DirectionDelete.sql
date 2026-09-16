use HeartyHearthDB
go

create or alter procedure dbo.DirectionDelete(
    @DirectionId int = 0,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0
    select @DirectionId = isnull(@DirectionId, 0)

    delete Direction where DirectionId = @DirectionId

   ; with x as
        (
            select DirectionId,
            NewSequence = ROW_NUMBER() over (partition by RecipeId order by RecipeSequence, DirectionId)
            from Direction d
        )
            update d
            set 
                RecipeSequence = x.NewSequence
            from Direction d
            join x
            on x.DirectionId = d.DirectionId

    return @return
end
go

select * from Direction