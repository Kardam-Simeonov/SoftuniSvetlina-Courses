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

-- 3. Town Names Starting With
CREATE PROC usp_GetTownsStartingWith(@Input nvarchar(50))
AS
BEGIN
	SELECT [Name] as Town
	FROM Towns
	WHERE [Name] LIKE @Input + '%';
END

--GO
--EXEC usp_GetTownsWith @Input = 'b'

-- 4. Employees from Town
CREATE PROC usp_GetEmployeesFromTown(@TownName nvarchar(50))
AS
BEGIN
	SELECT FirstName, LastName
	FROM Employees
	JOIN Addresses ON Employees.AddressID = Addresses.AddressID
	JOIN Towns ON Addresses.TownID = Towns.TownID 
	WHERE Towns.Name = @TownName
END

--GO
--EXEC usp_GetEmployeesFromTown @TownName = 'Sofia'

-- 5. Employees by Salary Level
CREATE FUNCTION ufn_GetSalaryLevel(@Salary DECIMAL(18,4))
RETURNS VARCHAR(10) AS
BEGIN
	DECLARE @SalaryLevel VARCHAR(10)
	SET @SalaryLevel =
		CASE
			WHEN @Salary < 30000 THEN 'Low'
			WHEN @Salary <= 50000 THEN 'Average'
			ELSE 'High'
		END
	RETURN @SalaryLevel
END

CREATE PROC usp_EmployeesBySalaryLevel(@SalaryLevel varchar(10))
AS
BEGIN
	SELECT FirstName, LastName 
	FROM Employees
	WHERE dbo.ufn_GetSalaryLevel(Salary) = @SalaryLevel
END

--GO
--EXEC usp_EmployeesBySalaryLevel

-- 6. Define Function
CREATE FUNCTION ufn_IsWordComprised(@SetOfLetters varchar(50), @Word varchar(50))
RETURNS BIT AS
BEGIN
	DECLARE @WordLength INT = LEN(@word)
	DECLARE @Index INT = 1

	WHILE (@Index <= @WordLength)
	BEGIN
		IF (CHARINDEX(SUBSTRING(@word, @Index, 1), @setOfLetters) = 0)
		BEGIN
			RETURN 0
		END

		SET @Index += 1
	END

	RETURN 1
END