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
