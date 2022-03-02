CREATE DATABASE Service
GO

USE Service;

CREATE TABLE Users(
	ID int UNIQUE IDENTITY(1, 1),
	Username varchar(30) UNIQUE NOT NULL,
	Password varchar(50) NOT NULL,
	Name varchar(50),
	Birthdate datetime,
	Age int CHECK (Age>=14 AND Age <= 110),
	Email varchar(50) NOT NULL
);

CREATE TABLE Departments(
	ID int UNIQUE IDENTITY(1, 1),
	Name varchar(50) NOT NULL
);

CREATE TABLE Employees(
	ID int UNIQUE IDENTITY(1, 1),
	FirstName varchar(25),
	LastName varchar(25),
	Birthdate datetime,
	Age int CHECK (Age>=14 AND Age <= 110),
	DepartmentID int FOREIGN KEY REFERENCES Departments(ID)
);

CREATE TABLE Categories(
	ID int UNIQUE IDENTITY(1, 1),
	Name varchar(50) NOT NULL,
	DepartmentID int FOREIGN KEY REFERENCES Departments(ID) NOT NULL
);

CREATE TABLE Status(
	ID int UNIQUE IDENTITY(1, 1),
	Label varchar(30) NOT NULL
);

CREATE TABLE Reports(
	ID int UNIQUE IDENTITY(1, 1),
	CategoryID int FOREIGN KEY REFERENCES Categories(ID) NOT NULL,
	StatusID int FOREIGN KEY REFERENCES Status(ID) NOT NULL,
	OpenDate datetime NOT NULL,
	CloseDate datetime,
	Description varchar(200) NOT NULL,
	UserID int FOREIGN KEY REFERENCES Users(ID) NOT NULL,
	EmployeeID int FOREIGN KEY REFERENCES Employees(ID)
);


INSERT INTO Employees (FirstName, LastName, Birthdate, DepartmentID) VALUES(
	'Marlo', 'O''Malley', '1958-9-21', 1
);

INSERT INTO Employees (FirstName, LastName, Birthdate, DepartmentID) VALUES(
	'Niki', 'Stanaghan', '1969-11-26', 4
);

INSERT INTO Employees (FirstName, LastName, Birthdate, DepartmentID) VALUES(
	'Ayrton', 'Senna', '1960-03-21', 9
);

INSERT INTO Employees (FirstName, LastName, Birthdate, DepartmentID) VALUES(
	'Ronnie', 'Peterson', '1944-02-14', 9
);

INSERT INTO Employees (FirstName, LastName, Birthdate, DepartmentID) VALUES(
	'Giovanna', 'Amati', '1959-07-20', 5
);


INSERT INTO Reports (CategoryID, StatusID, OpenDate, Description, UserID, EmployeeID) VALUES(
	1, 1,'2017-04-13', 'Stuck Road on Str.133', 6, 2
);

INSERT INTO Reports (CategoryID, StatusID, OpenDate, CloseDate, Description, UserID, EmployeeID) VALUES(
	6, 3,'2015-09-05', '2015-12-06', 'Charity trail running', 3, 5
);

INSERT INTO Reports (CategoryID, StatusID, OpenDate, Description, UserID, EmployeeID) VALUES(
	14, 2,'2015-09-07', 'Falling bricks on Str.58', 5, 2
);

INSERT INTO Reports (CategoryID, StatusID, OpenDate, CloseDate, Description, UserID, EmployeeID) VALUES(
	4, 3,'2017-07-03', '2017-07-06', 'Cut off streetlight on Str.11', 1, 1
);

UPDATE Reports
SET CloseDate = OpenDate 
WHERE CloseDate IS NULL;

DELETE Reports
FROM Reports 
INNER JOIN Status 
	ON Status.ID = StatusID
WHERE Status.Label = 'Status 4';

SELECT Description, FORMAT (OpenDate, 'dd-MM-yyyy') as Date
FROM Reports
WHERE EmployeeID IS NULL
ORDER BY OpenDate ASC,
Description ASC;

SELECT Description, Categories.Name
FROM Reports
INNER JOIN Categories ON Categories.ID = CategoryID
ORDER BY Description ASC, Categories.Name ASC;

SELECT TOP(5) Categories.Name, COUNT(CategoryID) AS ReportsNumber
FROM Reports
INNER JOIN Categories ON Categories.ID = CategoryID
GROUP BY Categories.Name
ORDER BY ReportsNumber DESC, Categories.Name ASC;