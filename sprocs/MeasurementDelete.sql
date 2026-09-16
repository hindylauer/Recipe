use HeartyHearthDB
go

create or alter proc dbo.MeasurementDelete(
    @MeasurementId int output,
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    select @MeasurementId = isnull(@MeasurementId, 0)

begin try
    begin transaction

    delete ri
    from RecipeIngredient ri
    where ri.MeasurementId = @MeasurementId

    delete m
    from Measurement m
    where m.MeasurementId = @MeasurementId

    commit transaction
end try
begin catch
    rollback transaction
    throw
end catch

    return @return
end
go

     