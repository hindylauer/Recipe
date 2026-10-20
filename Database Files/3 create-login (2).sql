--IMPORTANT create login in MASTER
--use MASTER
create login recipeappadmin with PASSWORD = 'Recipe123!'

--important switch to HeartyHearthDB
create user recipeappadmin_user from login recipeappadmin

