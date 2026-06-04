/*
Hearty Hearth- Recipe Website
Looking for help managing the website
Recipes, meals, cookbooks
Show recipe on one page, may be part of a meal, or part of cookbook- duplicated on multiple pages, fix something in one place, but then don't switch in different place.

Recipes-
most basic, has cuisine type- chinese, mediterranean...
-master list of cuisines. If someone comes up with recipe with new cusine, needs to be added.
There's a page list of cuisine. -approved in master list.
recipe has list ingredients
Each ingredient has a measurement type (desc) and an amount, directions and steps- steps in particular order.- have a number.
ex: 3 oz water, 1 pound flour

-Status of recipe, first in draft, not shown on website, staff work, publish on website, ppl can view, then after a while put on archive.
Need to know when draft, published and archived- date and time- so can know how long staff member worked on it...
-Regular staff should be able to move it from draft, published, to archive.
-Archived, not deleted.
when present ingredients, put in spicific order- record sequence in recipe.

Meals- 
Staff creates meals, give it a meal, go into meal, give 
courses- appetizer, main, dessert...- each course can have multiple recipes
course has sequence in the meal.
-Every ingredient, recipe, meal, cookbook are unique

-course there are recipes, can have multiple recipes
-meal- multiple courses.
can't repeat course type
-meal shouldn't have 2 appetizers
2 appetizers are in the appetizer course with 2 recipes, can sequence them if you wish.
-Main can have a lot of recipes- those are multiple recipes part of main course, but there aren't 2 main courses.


CookBooks- simple
Name, Price, recipes in it- have certain sequence how presented in cookbook
don't put meal in cookbook

Picture- anything with pic belongs to cetain type-
name of pic very tight
first put name of type, then name of ingredient
ingredient-baby-carrot
no spaces, punctuation
all jpg

-Recipe more intense in terms of status
meals and cookbooks- collection of recipes-
active- on site, inactive- on site, don't need date.

User-
-Staff- firstname, lastname, username
what we need to know, anything created, who is user-
meal created by user...

cloning recipe- way to clone, will provide the info later

Q: You mentioned that one course can have multiple recipes. Is it important to differentiate between the main dish and side dishes? 
A: Yes, we need to record which recipe is the main dish and which are side dishes. This will allow us to display the course properly with the main dish in the center. If there is no main and side then we will display all the recipes in the course the same without emphasis on a single recipe.

Q: Can the status of a recipe go straight from drafted to archived? 
A: Yes, we may have a recipe which does not meet our standards and don't have time to work on it, so we archive it to get it out of the way, and then when we have time, we'll take it out of archive back to draft, and then publish it.

Q: Do you want to record how many calories there are in a recipe? 
A: Yes. 

Q: You mentioned that the dates when meals and cookbooks become active or inactive are not important to you. However, would you be interested in keeping record of the dates they were created instead? 
A: Yes.

Q from client: My website designer explained to me that the content for the web pages come from the database, and that the images on the web page are based on the file names, and those file name have to be part of the data that populates the site. The developer told me to double check with you that the file name will be in the database. Is that part of the spec?
A: Yes, for sure, I understood that from our interview and it will be done.
Q from client: Good, web designer also asked to double check that you got our picture file name format Entity_Entity_Name.jpg like Recipe_French_Toast.jpg. I think I previously mentioned to use dashes between the words, but we would actually need underscores instead. Sorry for being paranoid, its just we worked hard on this and want to ensure that the new database integrates smoothly with our existing system.

A: Yes, I got the revised format, will use underscores instead of dashes. And no worries about double checking, it is best to be clear especially at early stages of the development process because we are building the foundation of the system.


*/