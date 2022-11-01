CREATE FUNCTION udf_ProjectDurationWeeks (@Start DATETIME, @End DATETIME)
RETURNS INT
AS
BEGIN
	DECLARE @projectWeeks INT;
	IF(@End IS NULL)
		SET @End = GETDATE();

	SET @projectWeeks = DATEDIFF(WEEK, @Start, @End)
	RETURN @projectWeeks;
END;

CREATE FUNCTION udf_GetSalaryLevel(@Salary DECIMAL(18,4))
RETURNS nvarchar(10)
AS
BEGIN
	DECLARE @SalaryLevel nvarchar(10);

	IF(@Salary < 30000)
		SET @SalaryLevel = 'Low';
	ELSE IF(@Salary <= 50000)
		SET @SalaryLevel = 'Average';
	ELSE
		SET @SalaryLevel = 'High';

	RETURN @SalaryLevel;
END;

CREATE PROC usp_SelectEmployeesBySeniority(@minYearsAtWork int = 5)
AS
	SELECT FirstName, LastName, HireDate,
	DATEDIFF(Year, HireDate, GETDATE()) as Years
	FROM Employees
	WHERE DATEDIFF(Year, HireDate, GETDATE()) > @minYearsAtWork
	ORDER BY HireDate
GO

CREATE PROC usp_AssignProject(@employeeId int = 1, @projectId int = 1)
AS
	SELECT FirstName, LastName, HireDate,
	DATEDIFF(Year, HireDate, GETDATE()) as Years
	FROM Employees
	WHERE DATEDIFF(Year, HireDate, GETDATE()) > @minYearsAtWork
	ORDER BY HireDate
GO

CREATE PROCEDURE udp_AssignProject
(@EmployeeID INT, @ProjectID INT)
AS
BEGIN
	DECLARE @maxEmployeeProjectsCount INT = 3
	DECLARE @employeeProjectsCount INT

	SET @employeeProjectsCount =
	(SELECT COUNT(ProjectID)
	FROM [dbo].[EmployeesProjects] AS ep
	WHERE ep.EmployeeId = @EmployeeID)

	IF(@employeeProjectsCount >= @maxEmployeeProjectsCount)
	BEGIN
		THROW 50001, 'The employee has too many projects!', 1;
	END

	INSERT INTO [dbo].[EmployeesProjects](EmployeeID, ProjectID)
	VALUES (@EmployeeID, @ProjectID)
END