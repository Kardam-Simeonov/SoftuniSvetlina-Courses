CREATE TABLE Person(
	PersonID int PRIMARY KEY,
	FirstName varchar(50),
	LastName varchar(50)
);

CREATE TABLE [Address](
	AddressID int PRIMARY KEY,
	PersonID int FOREIGN KEY REFERENCES Person(PersonID),
	City varchar(50),
	[State] varchar(50)
);

SELECT Person.FirstName, Person.LastName, [Address].City, [Address].[State]
FROM Person
LEFT JOIN [Address] ON Person.PersonID = [Address].PersonID;


