CREATE PROCEDURE `list_tables` ()
BEGIN
	select * from idcards; 
    select * from students;
    select * from subjects;
    select * from teachers;
    select * from teacherssubjects;
END
