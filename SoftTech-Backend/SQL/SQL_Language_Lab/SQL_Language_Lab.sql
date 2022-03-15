USE SoftUni

SELECT * FROM DEPARTMENTS;

SELECT Name FROM Departments; 

SELECT FirstName, LastName, Salary FROM Employees;

SELECT DISTINCT Salary FROM Employees;

SELECT FirstName, LastName, JobTitle FROM Employees WHERE Salary BETWEEN 20000 AND 30000;

SELECT FirstName, LastName FROM Employees WHERE ManagerID IS NULL;

SELECT FirstName, LastName, Salary FROM Employees WHERE Salary > 50000 ORDER BY Salary DESC;

SELECT TOP(5) FirstName, LastName FROM Employees ORDER BY Salary DESC;

SELECT TOP(7) FirstName, LastName, HireDate FROM Employees ORDER BY HireDate DESC;

UPDATE Employees 
	SET Salary = Salary * 1.12 
	WHERE DepartmentID IN (1, 2, 4, 11);

SELECT Salary FROM Employees;

SELECT TOP(5) Employees.EmployeeID, Employees.JobTitle, Employees.AddressID, Addresses.AddressText
FROM Employees
INNER JOIN Addresses ON Employees.AddressID = Addresses.AddressID
ORDER BY Employees.AddressID ASC;

SELECT TOP(50) Employees.FirstName, Employees.LastName, Towns.[Name], Addresses.AddressText
FROM Employees
INNER JOIN Addresses ON Employees.AddressID = Addresses.AddressID
INNER JOIN Towns ON Addresses.TownID = Towns.TownID
ORDER BY Employees.FirstName ASC, Employees.LastName ASC;

SELECT Employees.EmployeeID, Employees.FirstName, Employees.LastName, Departments.[Name]
FROM Employees
INNER JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID
WHERE Departments.Name = 'Sales'
ORDER BY Employees.EmployeeID ASC;

SELECT TOP(5) Employees.EmployeeID, Employees.FirstName, Employees.Salary, Departments.[Name]
FROM Employees
INNER JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID
WHERE Employees.Salary > 15000
ORDER BY Departments.DepartmentID ASC;

SELECT TOP(3) Employees.EmployeeID, Employees.FirstName
FROM Employees
LEFT JOIN EmployeesProjects ON Employees.EmployeeID = EmployeesProjects.EmployeeID
WHERE EmployeesProjects.ProjectID IS NULL
ORDER BY Employees.EmployeeID ASC;

SELECT Employees.FirstName, Employees.LastName, Employees.HireDate, Departments.Name
FROM Employees
INNER JOIN Departments ON Employees.DepartmentID = Departments.DepartmentID
WHERE Employees.HireDate > '1/1/1999' AND Departments.Name = 'Sales' OR Departments.Name = 'Finance'
ORDER BY Employees.HireDate ASC;


