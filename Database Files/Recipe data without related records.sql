alter table recipe
alter column CuisineId int null

alter table recipe
alter column WebUserID int null

insert Recipe(RecipeName, DateDrafted, DatePublished, DateArchived, AmountCalories)
select 'Pancakes', '2024-01-01', null, null, 100
union select 'Mango Sorbet', '2010-10-10', '2012-10-10', null, 65
union select 'French Fries', '2023-10-10', '2023-11-12', '2025-11-12', 120
union select 'Steak', '2024-04-12', '2024-11-11', '2025-09-07', 85
union select 'Cholent', '2018-10-10', '2018-11-12', null, 150
union select 'Pizza', '2022-08-08', '2023-08-08', '2024-08-08', 110
union select 'Milkshake', '2023-10-14', '2023-11-16', '2025-11-16', 200
union select 'Veggie Wrap', '2011-10-16', '2023-11-18', '2025-04-18', 70
union select 'Mozzarella Sticks', '2012-08-18', '2014-11-20', '2025-11-20', 80
union select 'BBQ Ribs', '2023-01-10', '2023-02-14', '2025-02-18', 100
union select 'Chocolate Cake', '2022-04-05', '2022-05-10', '2024-05-15', 95
union select 'Fettucini Alfredo', '2010-09-09', '2017-05-17', '2025-05-15', 165
union select 'Caesar Salad', '2022-12-01', '2023-01-05', '2025-02-13', 65
union select 'Hamburger', '2012-12-12', '2013-03-03', null, 140
union select 'Baked Potato', '2016-06-26', '2017-07-17', '2019-09-29', 90
union select 'Onion Rings', '2020-05-25', '2020-06-26', '2022-12-22', 135
union select 'Peanut Butter Ice Cream', '2015-05-16', null, null, 180

select *
from recipe

