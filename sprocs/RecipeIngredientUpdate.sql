use HeartyHearthDB
go

create or alter procedure dbo.RecipeIngredientUpdate(
	@RecipeIngredientId int output,
    @RecipeId int,
    @IngredientId int,
    @MeasurementId int,
    @MeasurementAmount decimal (10,2),
    @IngredientSequence int,
	@Message varchar(500) = output
	)
as
begin
	declare @return int = 0
	
select @RecipeIngredientId = isnull(@RecipeIngredientId, 0)

    if @RecipeIngredientId = 0
    begin
        insert RecipeIngredient(RecipeId, IngredientId, MeasurementId, MeasurementAmount, IngredientSequence)
        values(@RecipeId, @IngredientId, @MeasurementId, @MeasurementAmount, @IngredientSequence)

        select @RecipeIngredientId = SCOPE_IDENTITY()
end
else 
begin
    update RecipeIngredient
    set
        RecipeId = @RecipeId,
        IngredientId = @IngredientId,
        MeasurementId = @MeasurementId,
        MeasurementAmount = @MeasurementAmount,
        IngredientSequence = @IngredientSequence
        where RecipeIngredientId = @RecipeIngredientId
    end

    return @return
    end
    go

