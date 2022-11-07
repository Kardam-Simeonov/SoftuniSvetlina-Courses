USE SoftUni
GO

-- 1. Find Names of All Employees by First Name
SELECT FirstName, LastName
FROM Employees
WHERE FirstName LIKE 'Sa%';

-- 2. Find Names of All employees by Last Name
SELECT FirstName, LastName
FROM Employees
WHERE LastName LIKE '%ei%';

-- 3. Find First Names of All Employees
SELECT FirstName
FROM Employees
WHERE (DepartmentID = 3 OR DepartmentID = 10)
AND DATEPART(YEAR, HireDate) BETWEEN 1995 AND 2005;

-- 4. Find All Employees except Engineers
SELECT FirstName, LastName
FROM Employees
WHERE JobTitle NOT LIKE '%engineer%';

-- 5. Find Towns with Name Length
SELECT [Name]
FROM Towns
WHERE LEN([Name]) = 5 OR LEN([Name]) = 6
ORDER BY [Name];

-- 6. Find Towns Starting With
SELECT TownID, [Name]
FROM Towns
WHERE LEFT(Name,1) LIKE '[MKBE]'
ORDER BY [Name];

-- 7. Find Towns Not Starting With
SELECT TownID, [Name]
FROM Towns
WHERE LEFT(Name,1) NOT LIKE '[RBD]'
ORDER BY [Name];

-- 8. Create View Employees Hired After 2000 Year
CREATE VIEW V_EmployeesHiredAfter2000
AS
     SELECT FirstName,
            LastName
     FROM Employees
     WHERE DATEPART(YEAR, HireDate) > 2000;

-- 9. Length of Last Name
SELECT FirstName, LastName
FROM Employees
WHERE LEN(LastName) = 5;

-- 10. Rank Employees by Salary
SELECT EmployeeId, FirstName, LastName, Salary,
DENSE_RANK() 
    OVER(PARTITION BY Salary
        ORDER BY EmployeeId) AS [Rank]
FROM Employees
WHERE Salary BETWEEN 10000 and 50000
ORDER BY Salary DESC;


USE [Geography]
GO

-- 12. Countries Holding ‘A’ 3 or More Times
SELECT CountryName,
       IsoCode AS [ISO Code]
FROM Countries
WHERE CountryName LIKE '%a%a%a%'
ORDER BY IsoCode;

-- 13. Mix of Peak and River Names
SELECT Peaks.PeakName,
       Rivers.RiverName,
       LOWER(CONCAT(LEFT(Peaks.PeakName, LEN(Peaks.PeakName)-1), Rivers.RiverName)) AS Mix
FROM Peaks,
     Rivers
WHERE RIGHT(PeakName, 1) = LEFT(RiverName, 1)
ORDER BY Mix;


USE Diablo
GO

-- 14. Games from 2011 and 2012 year
SELECT TOP(50) [Name], FORMAT(CAST([Start] AS DATE), 'yyyy-MM-dd') AS [Start]
FROM Games
WHERE DATEPART(YEAR, [Start]) BETWEEN 2011 AND 2012
ORDER BY [Start], [Name];

-- 15. User Email Providers
SELECT Username, RIGHT(Email, LEN(Email)-CHARINDEX('@', Email)) AS [Email Provider]
FROM Users
ORDER BY [Email Provider], Username;

-- 16. Get Users with IP Address Like Pattern
SELECT Username, IpAddress 
FROM Users
WHERE IpAddress LIKE '___.1_%._%.___'
ORDER BY Username;