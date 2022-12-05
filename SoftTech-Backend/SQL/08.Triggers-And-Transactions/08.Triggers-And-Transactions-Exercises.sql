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

CREATE PROC usp_DepositMoney (@AccountId INT, @MoneyAmount DECIMAL(16,2))
AS
BEGIN TRANSACTION
IF (@recieverAccountId IS NULL OR @senderAccountId IS NULL)
BEGIN
	ROLLBACK
	RAISERROR('Invalid account', 16, 1);
	RETURN
END
UPDATE Accounts SET Balance = Balance - @amount
	WHERE AccountId = @senderAccountId;
UPDATE Accounts SET Balance = Balance + @amount
	WHERE AccountId = @recieverAccountId;
IF @@ROWCOUNT <> 1 -- Didn’t affect exactly one row
BEGIN
	ROLLBACK
	RAISERROR('Invalid operation!', 16, 2);
	RETURN
END
COMMIT