CREATE DATABASE GradeDb
GO

USE GradeDb
GO

CREATE TABLE Grades(
	Id int PRIMARY KEY IDENTITY(1,1),
	Name nvarchar(50),
	Class int,
	Subject nvarchar(50),
	StudentGrade decimal 
	);



