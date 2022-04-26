CREATE DATABASE VendingMachines
GO

USE VendingMachines
GO

CREATE TABLE Machines(
	Id int PRIMARY KEY IDENTITY(1,1),
	DateOfPlacement DateTime,
	Type nvarchar(50),
	Latitude nvarchar(50),
	Logitude nvarchar(50)
);