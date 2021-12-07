-- Create database restaurant; 
-- while other dbs are more lax in mysql you MUST end each query in a semicolon. 

-- create table dishes(
-- 	id int not null auto_increment primary key, 
--     `name` nvarchar(20) not null, 
--     price float not null,
--     isVegetarian bit, 
--     isHealthy bit, 
--     -- we want it to be a number from 1 to 10, we need to rember that mysql wont enforce a max 
--     spiceLevel int 
-- );
-- we'll put in 0 for our id, which gets auto-increment to supply it's own id. 
-- auto_increment will start at one and tick up for each row
-- insert into dishes 
-- values(0, 'GP Porkchop', 10.00, 0, 0, 10), 
-- (0, 'Nuclear Pepper Salad', 8.00, 1, 1, 8), 
-- (0, 'Cheese soup', 4.00, 1, 0, 5 ), 
-- (0, 'Shrimp pasta', 12.00, 0,1, 2 );

-- update dishes 
-- set price = 13.00
-- where `name` = 'GP Porkchop';

-- mysql is not case sensitive when comparing strings
-- delete from dishes 
-- where `name` = 'cheese Soup';

-- drop is permanent and wipes all data from the table's columns and rows 
-- drop table dishes;
-- drop database restaurant; 

-- select * from dishes;