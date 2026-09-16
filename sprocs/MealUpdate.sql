create or alter proc dbo.MealUpdate(

@MealId int output,
@WebUserId int,
@MealName varchar(35),
@DateMealCreated datetime,
@Active int
)
as
begin
    declare @return int = 0

    select @MealId = isnull(@MealId, 0)

        begin
        update Meal
        set
            WebUserId = @WebUserId, 
            MealName = @MealName, 
            DateMealCreated = @DateMealCreated, 
            Active = @Active
            where MealId = @MealId
        end

        return @return
end
go


select * from meal