SELECT FirstName, MiddleName, LastName FROM Employees;

Select FirstName + '.' + LastName + '@softuni.bg' AS [Full Email Address] FROM Employees;

SELECT * FROM Employees WHERE JobTitle = 'Sales Representative';

SELECT FirstName + ' ' + MiddleName + ' ' + LastName AS [Full Name]  
FROM Employees
WHERE Salary IN (25000, 14000, 12500, 23600);

SELECT FirstName, LastName
FROM Employees
WHERE DepartmentID != 4;

SELECT * FROM Employees
ORDER BY Salary DESC,
FirstName ASC,
LastName DESC,
MiddleName DESC;

SELECT DISTINCT JobTitle FROM Employees;

SELECT TOP(10) * FROM Projects
ORDER BY StartDate,
[Name];

SELECT TOP(5) Employees.EmployeeID, Employees.FirstName, Projects.[Name]
FROM Employees
INNER JOIN EmployeesProjects ON Employees.EmployeeID = EmployeesProjects.EmployeeID
INNER JOIN Projects ON EmployeesProjects.ProjectID = Projects.ProjectID
WHERE Projects.StartDate > '2002/08/13' AND Projects.EndDate IS NULL;

IF (Select Projects.StartDate FROM Projects) >= '2005/01/01'
BEGIN
	SELECT Employees.EmployeeID, Employees.FirstName, NULL
	FROM Employees
	WHERE Employees.EmployeeID = 24;
END
ELSE
BEGIN
	SELECT Employees.EmployeeID, Employees.FirstName, Projects.[Name]
	FROM Employees
	INNER JOIN EmployeesProjects ON Employees.EmployeeID = EmployeesProjects.EmployeeID
	INNER JOIN Projects ON EmployeesProjects.ProjectID = Projects.ProjectID
	WHERE Employees.EmployeeID = 24;
END

SELECT Employees.EmployeeID, Employees.FirstName, Managers.EmployeeID, Managers.FirstName
FROM Employees
INNER JOIN Employees AS Managers ON Employees.ManagerID = Managers.EmployeeID
WHERE Managers.EmployeeID IN (3, 7)
ORDER BY Employees.EmployeeID ASC;

SELECT TOP(50) Employees.EmployeeID, Employees.FirstName + ' ' + Employees.LastName AS EmployeeName, Managers.FirstName + ' ' + Managers.LastName AS ManagerName, Departments.[Name] as DepartmentName
FROM Employees
LEFT JOIN Employees AS Managers ON Employees.ManagerID = Managers.EmployeeID
LEFT JOIN Departments ON Employees.ManagerID = Departments.ManagerID
ORDER BY EmployeeID;






