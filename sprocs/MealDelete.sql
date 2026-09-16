create or alter procedure dbo.MealDelete(
    @MealId int,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0

    select @MealId = isnull(@MealId, 0)

begin try
    begin transaction

    delete rcm
    from RecipeCourseMeal rcm
    join CourseMeal cm
    on rcm.CourseMealId = cm.CourseMealId
    where cm.MealId = @MealId

    delete cm
    from CourseMeal cm
    where cm.MealId = @MealId

    delete Meal where @MealId = MealId

    commit transaction
end try
begin catch
    rollback transaction
    throw
    end catch

    return @return
end
go

