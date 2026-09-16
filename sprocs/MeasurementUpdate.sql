use HeartyHearthDB
go

create or alter proc dbo.MeasurementUpdate(
    @MeasurementId int output,
    @MeasurementDesc varchar(15),
    @Message varchar(500) = '' output
)
as
begin
    declare @return int = 0

    select @MeasurementId = isnull(@MeasurementId , 0)
    
    if @MeasurementId = 0
    begin
        insert Measurement(MeasurementDesc)
        values(@MeasurementDesc)

    select @MeasurementId = scope_identity()
end
else
    begin
        update Measurement
        set MeasurementDesc = @MeasurementDesc
        where MeasurementId = @MeasurementId
    end

    return @return
end
go