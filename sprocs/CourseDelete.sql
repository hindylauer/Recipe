use HeartyHearthDB
go

create or alter proc dbo.CourseDelete(
    @CourseId int output,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    select @CourseId = isnull(@CourseId, 0)

begin try
    begin transaction

    delete rcm
    from RecipeCourseMeal rcm
    join CourseMeal cm
    on rcm.CourseMealId = cm.CourseMealId
    where cm.CourseId = @CourseId

    delete cm
    from CourseMeal cm
    where cm.CourseId = @CourseId

    delete c
    from Course c
    where c.CourseId = @CourseId

    ;
    with x as
        (
            select CourseId,
            NewSequence = ROW_NUMBER() over (order by CourseSequence, CourseId)
            from Course
        )
            update c
            set 
                CourseSequence = x.NewSequence
            from Course c
            join x
            on x.CourseId = c.CourseId

    commit transaction
end try
begin catch
    rollback transaction
    throw
end catch
    return @return
end
go
