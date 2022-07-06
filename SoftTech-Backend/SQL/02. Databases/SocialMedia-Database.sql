CREATE DATABASE SocialMedia
GO

USE SocialMedia
GO

CREATE TABLE Users(
	Id int PRIMARY KEY IDENTITY(1,1),
	Username nvarchar(50),
	Password nvarchar(50) NOT NULL,
	FirstName nvarchar(50) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Age int NOT NULL,
	Gender nvarchar(6) NOT NULL
);

CREATE TABLE Posts(
	Title nvarchar(50) NOT NULL,
		Id int PRIMARY KEY IDENTITY(1,1),
Description nvarchar(250),
	
Username nvarchar(50)
);
CREATE TABLE DirectMessages(
	Id int PRIMARY KEY IDENTITY(1,1),
	Message nvarchar(250) NOT NULL,
	SenderName nvarchar(50),
	RecieverName nvarchar(50),
	TimeStamp DateTime NOT NULL
);

