
;
with x as(
select RecipeName = 'French Fries', WebUserName = 'hlauer', Cuisine = 'French', DateDrafted = '2023-10-10', DatePublished = '2023-11-12', DateArchived = '2025-11-12', AmountCalories = 120
union select 'Pancakes', 'Cbeer', 'American', '2024-01-01', null, null, 100
union select 'Mango Sorbet', 'elauer', 'American', '2010-10-10', '2012-10-10', null, 65
union select 'French Fries', 'hlauer', 'French', '2023-10-10', '2023-11-12', '2025-11-12', 120
union select 'Steak', 'mlauer', 'English', '2024-04-12', '2024-11-11', '2025-09-07', 85
union select 'Cholent', 'rweinberg', 'American', '2018-10-10', '2018-11-12', null, 150
union select 'Pizza', 'mlauer', 'American', '2022-08-08', '2023-08-08', '2024-08-08', 110
union select 'Milkshake','ylauer', 'French', '2023-10-14', '2023-11-16', '2025-11-16', 200
union select 'Veggie Wrap', 'ylauer', 'English', '2011-10-16', '2023-11-18', '2025-04-18', 70
union select 'Mozzarella Sticks', 'hlauer', 'French', '2012-08-18', '2014-11-20', '2025-11-20', 80
union select 'BBQ Ribs', 'rweinberg', 'English', '2023-01-10', '2023-02-14', '2025-02-18', 100
union select 'Chocolate Cake', 'hlauer', 'American', '2022-04-05', '2022-05-10', '2024-05-15', 95
union select 'Fettucini Alfredo', 'elauer', 'French', '2010-09-09', '2017-05-17', '2025-05-15', 165
union select 'Caesar Salad', 'emorris', 'French', '2022-12-01', '2023-01-05', '2025-02-13', 65
union select 'Hamburger', 'cbeer', 'English', '2012-12-12', '2013-03-03', null, 140
union select 'Baked Potato', 'hlauer', 'American', '2016-06-26', '2017-07-17', '2019-09-29', 90
union select 'Onion Rings', 'elauer', 'French', '2020-05-25', '2020-06-26', '2022-12-22', 135
union select 'Peanut Butter Ice Cream', 'ylauer', 'American', '2015-05-16', null, null, 180
)
insert Recipe(WebUserId, CuisineId, RecipeName, DateDrafted, DatePublished, DateArchived, AmountCalories)
select w.WebUserId, c.CuisineId, x.RecipeName, x.DateDrafted, x.DatePublished, x.DateArchived, x.AmountCalories
from x
join WebUser w
on w.WebUserName = x.WebUserName
join Cuisine c
on c.CuisineName = x.Cuisine

update recipe 
set RecipeName = 'Turkey Salad'
where RecipeName = 'Turkey Saladsss'