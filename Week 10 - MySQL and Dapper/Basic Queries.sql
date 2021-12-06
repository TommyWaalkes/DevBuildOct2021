/*create database Cats */
/*create Table Kitties(
	id Int NOT NULL  auto_increment primary key, 
    fName VARCHAR(15), 
    isDeclawed BIT, 
    age INT
   
)*/

/*Insert into Kitties 
values(0,'Meowser', 1, 5)*/
/*if you set it to 0, then auto-increment will handle it, you must give the Primary key a value*/
-- Insert into Kitties 
-- values(1,'Meow Zedong', 0, 10);

-- where clauses will only let you select along primary keys
-- UPDATE Kitties 
-- SET isDeclawed = 1
-- where id = 3;
-- WHERE age = 10;

-- delete from Kitties 
-- where id = 1;

select * from kitties; 
/*drop table Kitties */
