CREATE DATABASE
BankTransactions
GO
USE BankTransactions
GO
CREATE TABLE Accounts
(
AccountId INT PRIMARY KEY
, [NAME] VARCHAR (20)
, Balance MONEY
)
GO
INSERT INTO Accounts (AccountId, [NAME], Balance) VALUES (1, 'Tom', 100)
INSERT INTO Accounts (AccountId, [NAME], Balance) VALUES (2, 'Jerry', 50)
GO

-- 1. Bank Transactions
CREATE PROC usp_SendMoney (@senderAccountId INT, @recieverAccountId INT, @amount DECIMAL(18,2))
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

-- 2. Trigger Accounts Delete
ALTER TABLE Accounts ADD IsDeleted BIT;

CREATE TRIGGER tr_AccountsDelete
ON Accounts
INSTEAD OF DELETE
AS
	UPDATE Accounts SET IsDeleted = 1
	WHERE AccountId IN (SELECT AccountId FROM deleted);