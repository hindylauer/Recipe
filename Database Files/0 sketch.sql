/*
HeartyHearthDB


Cuisine
    CuisineId int not null identity primary key,
    CuisineName varchar(50) not null 
        constraint c not blank,
            unique constraint

User
    UserId int not null identity primary key,
    UserFirstName varchar(50) not null,
        constraint c not blank
    UserLastName varchar(50) not null,
        constraint c not blank
    UserName varchar(50) not null
        constraint c not blank
        unique constraint

Recipe
    RecipeId int not null identity primary key,
    UserId foreign key,
    CusineId foreign key,
    RecipeName varchar(50) not null
        constraint c not blank,
    DateDrafted datetime
    constraint c between January 1, 2000 and currentdate
    DatePublished datetime
    constraint c between January 1, 2000 and currentdate
    DateArchived datetime
    constraint c between January 1, 2000 and currentdate
    RecipeStatus as (case when DateArchived is not null then 'Archived'
    when DatePublished is not null then 'published'
    else 'draft' end) persisted
    when DateDrafted is null and DateArchived is null then 'DatePublished'
    when DatePublished is null and DateArchived is null then 'DateDrafted' end,
    AmountCalories int not null,
        constraint c greater than zero
    RecipeImage as conacat('Recipe', '_', replace(RecipeName, ' ', '_'), '_.jpg')
            unique constraint
                multi column constraints:
--AS A recipe can go directly from draft to archived so you need to check for that too.
                DatePublished IS NULL OR DateDrafted IS NULL OR DatePublished >= DateDrafted
                DateArchived IS NULL OR DatePublished IS NULL OR DateArchived >= DatePublished
                DateArchived IS NULL OR DateDrafted IS NULL OR DateArchived >= DateDrafted

Ingredient
    IngredientId int not null identity primary key,
    IngredientName varchar(30) not null
        constraint c not blank,
    IngredientImage as conacat('Ingredient', '-', replace(IngredientName, ' ', '-'), '-.jpg')
            unique constraint

Measurement
    MeasurementId int not null identity primary key,   
    MeasurementDesc varchar(15) not null
        constraint c not blank

RecipeIngredient
    RecipeIngredientId int not null identity primary key,
    RecipeId foreign key,
    IngredientId foreign key,
    MeasurementId foreign key,
    MeasurementAmount decimal(10,2) not null
        constraint c greater than zero,
    IngredientSequence int not null
        constraint c greater than zero       
            unique constraint RecipeId, IngredientId

Direction
    DirectionId int not null identity primary key,
    RecipeId foreign key,
    IngredientStep int not null,
    IngredientDirection varchar(150) not null
        constraint c not blank,

Meal
    MealId int not null identity primary key,
    UserId foreign key,
    MealName varchar(35) not null
        constraint c not blank,
    DateMealCreated date
        constraint c DateMealCreated between January 1, 2000 and current date,
    Active bit not null
    MealImage as conacat('Meal', '-', replace(MealName, ' ', '-'), '-.jpg')
            Unique constraint

Course
    CourseId int not null identity primary key,
    CourseName varchar(35) not null,
        constraint c not blank
    CourseSequence int not null
        constraint c CourseSequence must be greater than zero
            unique constraint

CourseMeal
    CourseMealId int not null identity primary key,
    CourseId foreign key,
    MealId foreign key,
            unique constraint CourseId and MealId

RecipeCourseMeal
    RecipeCourseMeal int not null identity primary key,
    RecipeId foreign key,
    CourseMealId foreign key,
    CourseType bit default 0
            unique constraint CourseMealId and RecipeId

CookBook
    CookBookId int not null identity primary key,
    UserId foreign key,
    CookBookName varchar(50) not null
        constraint c not blank,
        unique constraint
    CookBookPrice int not null
        constraint c greater than zero,
    DateCookBookCreated date
        constraint c DateCookBookCreated between January 1, 2000 and getdate(),
    Active bit not null
    CookBookImage as conacat('CookBook', '-', replace(CookBook, ' ', '-'), '-.jpg')

RecipeCookBook
    RecipeCookBookId int not null idenity primary key,
    RecipeId foreign key,
    CookBookId foreign key,
    RecipeSequence int not null
        constraint c greater than zero,



    




*/

