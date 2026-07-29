create or alter procedure dbo.RecipeDelete(@RecipeId int)
as 
begin
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
end
go