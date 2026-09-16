use HeartyHearthDB
go

create or alter procedure dbo.MeasurementGet(@MeasurementId int = 0, @All bit = 0, @MeasurementDesc varchar(15) = '', @IncludeBlank bit = 0)
as
begin
	select @MeasurementDesc = nullif(@MeasurementDesc, ''), @IncludeBlank = isnull(@IncludeBlank, 0)
	select m.MeasurementId, m.MeasurementDesc
	from Measurement m
	where m.MeasurementId = @MeasurementId
	or @All = 1
	or m.MeasurementDesc like '%' + @MeasurementDesc + '%'
	union select 0, ' '
	where @IncludeBlank = 1
	order by m.MeasurementDesc
end
go

exec MeasurementGet

exec MeasurementGet @All = 1

declare @id int
select top 1 @id = m.MeasurementId from Measurement m
exec MeasurementGet @MeasurementId = @id

exec MeasurementGet @MeasurementDesc = 'a'

exec MeasurementGet @MeasurementDesc = null

exec MeasurementGet @MeasurementDesc = ''