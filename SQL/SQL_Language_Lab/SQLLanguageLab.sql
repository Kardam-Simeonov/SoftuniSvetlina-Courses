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


