CREATE DATABASE ToDoDB;

CREATE TABLE ToDoTasks(
	Id int PRIMARY KEY IDENTITY(1,1),
	Title nchar(50)
);

INSERT INTO ToDoTasks VALUES('Water the flowers.');
INSERT INTO ToDoTasks VALUES('Buy cat food.');
INSERT INTO ToDoTasks VALUES('Make the project for Wednesday.');