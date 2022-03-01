CREATE DATABASE ActiveVolcanoes

CREATE TABLE [Location](
	Id int IDENTITY(1, 1) PRIMARY KEY,
	Country varchar(50),
	Volcanoes int
);

CREATE TABLE Volcanoes(
	Id int IDENTITY(1, 1) PRIMARY KEY,
	[Name] varchar(50),
	LocationId int FOREIGN KEY REFERENCES Location(Id),
	Height int
);

INSERT INTO Location VALUES (
	'Argentina',
	57
);

INSERT INTO Location VALUES (
	'Ecuador',
	47
);

INSERT INTO Location VALUES (
	'Russia',
	192
);

INSERT INTO Volcanoes VALUES (
	'Antofalla',
	1,
	6450
);

INSERT INTO Volcanoes VALUES (
	'Cotopaxi',
	2,
	5897
);

INSERT INTO Volcanoes VALUES (
	'Guallatiri',
	1,
	6060
);

INSERT INTO Volcanoes VALUES (
	'Sangay',
	2,
	5320
);

INSERT INTO Volcanoes VALUES (
	'Kluchevskaya',
	3,
	4850
);

SELECT Name FROM Volcanoes
WHERE LocationId = 1;

SELECT * FROM Location
INNER JOIN Volcanoes ON Location.Id = Volcanoes.LocationId
WHERE Height < 6000;