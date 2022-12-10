----------------------------
-- Queries for Bank Database
USE Bank;
-- 1. Create Table Logs
CREATE TABLE Logs(
	Id int PRIMARY KEY,
	Recipient int,
	OldSum decimal(16,2),
	NewSum decimal(16,2)
)
GO

CREATE TRIGGER tr_Accounts_Logs_After_Update ON Accounts
AFTER UPDATE
AS
BEGIN
	INSERT INTO Logs
	VALUES(
		(SELECT Id FROM deleted),
		(SELECT Balance FROM deleted),
		(SELECT Balance FROM inserted)
	);
END;

-- 2. Create Table Emails
CREATE TABLE NotificationEmails(
	Id int PRIMARY KEY,
	Recipient int,
	[Subject] varchar(100),
	[Body] varchar(250)
)
GO

CREATE TRIGGER tr_Logs_NotificationEmails_After_Insert ON Accounts
AFTER UPDATE
AS
BEGIN
	INSERT INTO NotificationEmails
	VALUES(
		(SELECT Id FROM inserted),
		CONCAT('Balance change for account: ',(SELECT Id FROM inserted)),
		CONCAT('On ', 
			FORMAT(GETDATE(), 'dd-MM-yyyy HH:mm'), 
			' your balance was changed from ',
			(SELECT OldSum FROM Logs), 
			' to ',
			(SELECT NewSum FROM Logs), 
			'.')
	);
END;

-- 3. Deposit Money
CREATE PROC usp_DepositMoney (@AccountId INT, @MoneyAmount DECIMAL(16,4))
AS
BEGIN TRANSACTION
IF (@MoneyAmount < 0)
BEGIN
	ROLLBACK
	RAISERROR('Invalid Amount!', 16, 1);
	RETURN
END
UPDATE Accounts SET Balance = Balance + @MoneyAmount
	WHERE Id = @AccountId;
IF @@ROWCOUNT <> 1 -- Didn’t affect exactly one row
BEGIN
	ROLLBACK
	RAISERROR('Invalid operation!', 16, 2);
	RETURN
END
COMMIT

-- 4. Withdraw Money
CREATE PROC usp_WithdrawMoney (@AccountId INT, @MoneyAmount DECIMAL(16,4))
AS
BEGIN TRANSACTION
IF (@MoneyAmount < 0)
BEGIN
	ROLLBACK
	RAISERROR('Invalid Amount!', 16, 1);
	RETURN
END
UPDATE Accounts SET Balance = Balance - @MoneyAmount
	WHERE Id = @AccountId;
IF @@ROWCOUNT <> 1 -- Didn’t affect exactly one row
BEGIN
	ROLLBACK
	RAISERROR('Invalid operation!', 16, 2);
	RETURN
END
COMMIT

-- 5. Money Transfer
CREATE PROC usp_TransferMoney(@SenderId INT, @ReceiverId INT, @Amount DECIMAL(16,4))
AS
BEGIN TRANSACTION
IF (@Amount < 0)
BEGIN
	ROLLBACK
	RAISERROR('Invalid Amount!', 16, 1);
	RETURN
END
UPDATE Accounts SET Balance = Balance - @Amount
	WHERE Id = @SenderId;
UPDATE Accounts SET Balance = Balance + @Amount
	WHERE Id = @ReceiverId;
IF @@ROWCOUNT <> 1 -- Didn’t affect exactly one row
BEGIN
	ROLLBACK
	RAISERROR('Invalid operation!', 16, 2);
	RETURN
END
COMMIT

-------------------------------
-- Queries for SoftUni Database
USE SoftUni;
-- 7. Employees with Three Projects
CREATE PROC usp_AssignProject(@employeeId INT, @projectID INT)
AS
BEGIN TRANSACTION
DECLARE @ProjectsCount INT
SELECT @ProjectsCount = COUNT(EmployeeId) FROM EmployeesProjects WHERE EmployeeId = @employeeId;
IF (@ProjectsCount >= 3)
BEGIN
	ROLLBACK
	RAISERROR('The employee has too many projects!', 16, 1);
	RETURN
END
INSERT INTO EmployeesProjects
VALUES (@employeeId, @projectID);
IF @@ROWCOUNT <> 1 -- Didn’t affect exactly one row
BEGIN
	ROLLBACK
	RAISERROR('Invalid operation!', 16, 2);
	RETURN
END
COMMIT

-- 8. Delete Employees
CREATE TABLE Deleted_Employees(
	EmployeeId INT PRIMARY KEY, 
	FirstName NVARCHAR(50), 
	LastName NVARCHAR(50), 
	MiddleName NVARCHAR(50), 
	JobTitle NVARCHAR(100),
	DepartmentID INT,
	Salary DECIMAL(16,2)
);

CREATE TRIGGER tr_Employees_After_Delete ON Employees
AFTER DELETE
AS
BEGIN
INSERT INTO Deleted_Employees
    SELECT FirstName,
           LastName,
           MiddleName,
           JobTitle,
           DepartmentID,
           Salary
    FROM deleted;
END;