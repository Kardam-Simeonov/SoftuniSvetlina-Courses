USE SoftUni
GO

-- 1. Employees with Salary Above 35000
CREATE PROC usp_GetEmployeesSalaryAbove35000
AS
BEGIN
	SELECT FirstName, LastName
	FROM Employees
	WHERE Salary > 35000
END

--GO
--EXEC usp_GetEmployeeSalaryAbove35000

-- 2. Employees with Salary Above Number
CREATE PROC usp_GetEmployeesSalaryAboveNumber(@Input DECIMAL(18,4))
AS
BEGIN
	SELECT FirstName, LastName
	FROM Employees
	WHERE Salary >= @Input
END

--GO
--EXEC usp_GetEmployeesSalaryAboveNumber @Input = 48100


