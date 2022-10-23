USE Gringotts
GO

SELECT COUNT(*) AS [Count] FROM WizzardDeposits;

SELECT MAX(w.MagicWandSize) AS LongestMagicWand FROM WizzardDeposits AS w;

SELECT DepositGroup, MAX(w.MagicWandSize) AS LongestMagicWand 
FROM WizzardDeposits AS w
GROUP BY DepositGroup;

SELECT TOP(2) DepositGroup
FROM WizzardDeposits AS w
GROUP BY DepositGroup
ORDER BY AVG(w.MagicWandSize) ASC;

SELECT DepositGroup, SUM(w.DepositAmount) AS TotalSum
FROM WizzardDeposits as w
GROUP BY DepositGroup;

SELECT DepositGroup, SUM(w.DepositAmount) AS TotalSum
FROM WizzardDeposits as w
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup;

SELECT DepositGroup, SUM(w.DepositAmount) AS TotalSum
FROM WizzardDeposits as w
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup
HAVING SUM(w.DepositAmount) < 150000
ORDER BY TotalSum DESC;

SELECT DepositGroup, MagicWandCreator, MIN(DepositCharge) AS MinDepositCharge
FROM WizzardDeposits as w
GROUP BY MagicWandCreator, DepositGroup
ORDER BY MagicWandCreator, DepositGroup ASC;

SELECT CASE
WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
ELSE '[61+]' END AS AgeGroup,
COUNT(*) AS WizardCount
FROM WizzardDeposits
GROUP BY CASE
WHEN Age BETWEEN 0 AND 10 THEN '[0-10]'
WHEN Age BETWEEN 11 AND 20 THEN '[11-20]'
WHEN Age BETWEEN 21 AND 30 THEN '[21-30]'
WHEN Age BETWEEN 31 AND 40 THEN '[31-40]'
WHEN Age BETWEEN 41 AND 50 THEN '[41-50]'
WHEN Age BETWEEN 51 AND 60 THEN '[51-60]'
ELSE '[61+]' END
ORDER BY AgeGroup;

SELECT DISTINCT LEFT(FirstName, 1) AS FirstLetter
FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
ORDER BY FirstLetter;

SELECT DepositGroup, 
CASE
WHEN DepositExpirationDate > GetDate() THEN 1
ELSE 0 END AS IsDepositExpired,
AVG(DepositInterest) AS AverageInterest
FROM WizzardDeposits 
WHERE DepositStartDate > '01/01/1985'
GROUP BY DepositGroup
ORDER BY DepositGroup DESC, IsDepositExpired ASC;

USE SoftUni
GO

CREATE VIEW EarnMoreThan30000 AS
SELECT *
FROM Employees
WHERE Salary > 30000;
GO

DELETE FROM EarnMoreThan30000
WHERE ManagerId = 42;

UPDATE EarnMoreThan30000
SET Salary = Salary + 5000
WHERE DepartmentID = 1;

SELECT DepartmentId, AVG(Salary)
FROM EarnMoreThan30000
GROUP BY DepartmentId;