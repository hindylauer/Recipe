Use HeartyHearthDB
go

drop table RecipeCookBook
drop table CookBook
drop table RecipeCourseMeal
drop table CourseMeal
drop table Course
drop table Meal
drop table Direction
drop table RecipeIngredient
drop table Measurement
drop table Recipe
drop table WebUser
drop table Cuisine
drop table Ingredient


create table dbo.Cuisine(
    CuisineId int not null identity primary key,
    CuisineName varchar(50) not null 
        constraint c_Cuisine_CuisineName_cannot_be_blank check(CuisineName <> '')
        constraint u_Cuisine_CuisineName unique 
)
go

create table dbo.WebUser(
    WebUserId int not null identity primary key,
    WebUserFirstName varchar(50) not null,
        constraint c_WebUser_WebUserFirstName_cannot_be_blank check(WebUserFirstName <> ''),
    WebUserLastName varchar(50) not null,
        constraint c_WebUser_WebUserLastName_cannot_be_blank check(WebUserLastName <> ''),
    WebUserName varchar(50) not null
        constraint c_WebUser_WebUserName_cannot_be_blank check(WebUserName <> '')
        constraint u_WebUser_WebsUserName unique        
)
go

create table dbo.Recipe(
    RecipeId int not null identity primary key,
    WebUserId int not null constraint f_WebUser_Recipe foreign key references WebUser(WebUserId),
    CuisineId int not null constraint f_Cuisine_Recipe foreign key references Cuisine(CuisineId),
    RecipeName varchar(50) not null
        constraint c_Recipe_RecipeName_cannot_be_blank check(RecipeName <> '')
        constraint u_Recipe_RecipeName unique,
    DateDrafted datetime not null
        constraint c_Recipe_DateDrafted_must_be_between_01_01_2010_and_currentdate check(DateDrafted between '01/01/2010' and getdate()),
    DatePublished datetime
        constraint c_Recipe_DatePublished_before_currentdate check(DatePublished <= getdate()),
    DateArchived datetime
        constraint c_Recipe_DateArchived_before_currentdate check (DateArchived <= getdate()),
    RecipeStatus as case
                        when DateArchived is not null then 'Archived'
                        when DatePublished is not null then 'Published'
                        else 'Drafted' end persisted,
    AmountCalories int not null,
        constraint c_Recipe_AmountCalories_must_be_greater_than_zero check(AmountCalories > 0),
    RecipeImage as concat('Recipe_', replace(RecipeName, ' ', '_'), '.jpg'),
                constraint c_Recipe_DateDrafted_DatePublished_DatePublished_greater_or_equal_to_DateDrafted check(DatePublished >= DateDrafted),
                constraint c_Recipe_DateArchived_DatePublished_DateArchived_greater_or_equal_to_DatePublished check(DateArchived >= DatePublished),
                constraint c_Recipe_DateArchived_DateDrafted_DateArchived_greater_or_equal_to_DateDrafted check(DateArchived >= DateDrafted) 
) 
go

create table dbo.Ingredient(
    IngredientId int not null identity primary key,
    IngredientName varchar(30) not null
        constraint c_Ingredient_IngredientName_cannot_be_blank check(IngredientName <> '')
        constraint u_Ingredient_IngredientName unique,
    IngredientImage as concat('Ingredient_', replace(IngredientName, ' ', '_'), '.jpg')
)
go

create table dbo.Measurement(
    MeasurementId int not null identity primary key,
    MeasurementDesc varchar(15)
        constraint c_Measurement_MeasurementDesc_cannot_be_blank check(MeasurementDesc <> '')
        constraint u_Measurement_MeasurementDesc unique
)
go

create table dbo.RecipeIngredient(
    RecipeIngredientId int not null identity primary key,
    RecipeId int not null constraint f_RecipeIngredient_Recipe foreign key references Recipe(RecipeId),
    IngredientId int not null constraint f_RecipeIngredient_Ingredient foreign key references Ingredient(IngredientId),
    MeasurementId int constraint f_RecipeIngredient_Measurement foreign key references Measurement(MeasurementId),
    MeasurementAmount decimal(10,2)
        constraint c_RecipeIngredient_MeasurementAmount_must_be_greater_than_zero check(MeasurementAmount > 0),
    IngredientSequence int not null
        constraint c_RecipeIngredient_IngredientSequence_must_be_greater_than_zero check(IngredientSequence > 0),       
            constraint u_RecipeIngredient_RecipeId_IngredientId unique(RecipeId, IngredientId)
)
go

create table dbo.Direction(
    DirectionId int not null identity primary key,
    RecipeId int not null constraint f_Direction_Recipe foreign key references Recipe(RecipeId),
    RecipeSequence int not null,
    RecipeDirection varchar(150) not null
        constraint c_Direction_IngredientDirection_cannot_be_blank check(RecipeDirection <> '')
)
go

create table dbo.Meal(
    MealId int not null identity primary key,
    WebUserId int not null constraint f_Meal_User foreign key references WebUser(WebUserId),
    MealName varchar(35) not null
        constraint c_Meal_MealName_cannot_be_blank check(MealName <> '')
        constraint u_Meal_MealName unique,
    DateMealCreated date
        constraint c_Meal_DateMealCreated_between_01_01_2010_and_currentdate check(DateMealCreated between '01/01/2010' and getdate()),
    Active bit not null,
    MealImage as concat('Meal_', replace(MealName, ' ', '_'), '.jpg')

)
go

create table dbo.Course(
    CourseId int not null identity primary key,
    CourseName varchar(35) not null
        constraint c_Course_CourseName_cannot_be_blank check(CourseName <> '')
        constraint u_Course_CourseName unique,
    CourseSequence int not null
        constraint c_Course_CourseSequence_must_be_greater_than_zero check(CourseSequence > 0)

)
go

create table dbo.CourseMeal(
    CourseMealId int not null identity primary key,
    CourseId int not null constraint f_CourseMeal_Course foreign key references Course(CourseId),
    MealId int not null constraint f_CourseMeal_Meal foreign key references Meal(MealId),
        constraint u_CourseMeal_CourseId_MealId unique(CourseId, MealId)
)
go

create table dbo.RecipeCourseMeal(
    RecipeCourseMealId int not null identity primary key,
    RecipeId int not null constraint f_RecipeCourseMeal_Recipe foreign key references Recipe(RecipeId),
    CourseMealId int not null constraint f_RecipeCourseMeal_CourseMeal foreign key references CourseMeal(CourseMealId),
    CourseType bit default 0 not null
           constraint u_RecipeCourseMeal_CourseMealId_RecipeId unique(CourseMealId, RecipeId)
)
go

create table dbo.CookBook(
    CookBookId int not null identity primary key,
    WebUserId int not null constraint f_CookBook_WebUser foreign key references WebUser(WebUserId),
    CookBookName varchar(50) not null
        constraint c_CookBook_CookBookName_cannot_be_blank check(CookBookName <> '')
        constraint u_CookBook_CookBookName unique,
    CookBookPrice decimal(10,2) not null
        constraint c_CookBook_CookBookPrice_must_be_greater_than_zero check(CookBookPrice > 0),
    DateCookBookCreated date not null
        constraint c_CookBook_DateCookBookCreated__between_01_01_2010_and_currentdate check(DateCookBookCreated between '01/01/2010' and getdate()),
    Active bit not null,
    CookBookImage as concat('CookBook', '_', replace(CookBookName, ' ', '_'), '.jpg')
)
go

create table dbo.RecipeCookBook(
    RecipeCookBookId int not null identity primary key,
    RecipeId int constraint f_RecipeCookBook_Recipe foreign key references Recipe(RecipeId),
    CookBookId int constraint f_RecipeCookBook_CookBook foreign key references CookBook(CookBookId),
    RecipeSequence int not null
        constraint c_RecipeCookBook_RecipeSequence_must_be_greater_than_zero check(RecipeSequence > 0),
            constraint u_RecipeCookBook_RecipeId_CookBookId unique(RecipeId, CookBookId)
)


