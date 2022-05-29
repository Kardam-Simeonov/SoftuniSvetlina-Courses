CREATE DATABASE SocialMedia
GO

USE SocialMedia
GO

CREATE TABLE Users(
	Id int PRIMARY KEY IDENTITY(1,1),
	Username nvarchar(50) NOT NULL,
	Password nvarchar(50) NOT NULL,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Age int NOT NULL,
	Gender nvarchar(6) NOT NULL
);

CREATE TABLE Posts(
	Id int PRIMARY KEY IDENTITY(1,1),
	Title nvarchar(50) NOT NULL,
	Description nvarchar(250),
	UserId int FOREIGN KEY REFERENCES Users(Id)
);

CREATE TABLE DirectMessages(
	Id int PRIMARY KEY IDENTITY(1,1),
	Message nvarchar(250) NOT NULL,
	SenderId int FOREIGN KEY REFERENCES Users(Id),
	RecieverId int FOREIGN KEY REFERENCES Users(Id),
	TimeStamp DateTime NOT NULL
);