create or alter procedure dbo.RecipeDelete(
    @RecipeId int,
    @Message varchar(500) = '' output
)
as 
begin
    declare @return int = 0
    if exists(select * from recipe r where r.RecipeId = @RecipeId and (r.DateArchived is null or datediff(day, r.DateArchived, getdate()) <= 30) and r.RecipeStatus <> 'Drafted')
    begin
        select @return = 1, @Message = 'Cannot delete Recipe that is not yet archived for over 30 days or is not currently drafted'
        goto finished
    end

    begin try
    begin tran
    delete Direction where recipeid = @RecipeId
    delete RecipeIngredient where recipeid = @RecipeId
    delete Recipe where recipeid = @RecipeId
    commit
    end try
    begin catch
        rollback;
        throw
    end catch

    finished:
    return @return
end
go

