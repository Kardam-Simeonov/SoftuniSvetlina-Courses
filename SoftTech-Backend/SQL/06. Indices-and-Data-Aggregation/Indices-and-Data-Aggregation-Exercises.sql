USE Gringotts
GO

/* 1. Records' Count */
SELECT COUNT(*) AS [Count] FROM WizzardDeposits;

/* 2. Longest Magic Wand */
SELECT MAX(w.MagicWandSize) AS LongestMagicWand FROM WizzardDeposits AS w;

/* 3. Longest Magic Wand Per Deposit Groups */
SELECT DepositGroup, MAX(w.MagicWandSize) AS LongestMagicWand 
FROM WizzardDeposits AS w
GROUP BY DepositGroup;

/* 4. Smallest Deposit Group Per Magic Wand Size */
SELECT TOP(2) DepositGroup
FROM WizzardDeposits AS w
GROUP BY DepositGroup
ORDER BY AVG(w.MagicWandSize) ASC;

/* 5. Deposits Sum */
SELECT DepositGroup, SUM(w.DepositAmount) AS TotalSum
FROM WizzardDeposits as w
GROUP BY DepositGroup;

/* 6. Deposits Sum for Ollivander Family */
SELECT DepositGroup, SUM(w.DepositAmount) AS TotalSum
FROM WizzardDeposits as w
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup;

/* 7. Deposit Filter */
SELECT DepositGroup, SUM(w.DepositAmount) AS TotalSum
FROM WizzardDeposits as w
WHERE MagicWandCreator = 'Ollivander family'
GROUP BY DepositGroup
HAVING SUM(w.DepositAmount) < 150000
ORDER BY TotalSum DESC;

/* 8. Deposit Charge */
SELECT DepositGroup, MagicWandCreator, MIN(DepositCharge) AS MinDepositCharge
FROM WizzardDeposits as w
GROUP BY MagicWandCreator, DepositGroup
ORDER BY MagicWandCreator, DepositGroup ASC;

/* 9. Age Groups */
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

/* 10. First Letter */
SELECT DISTINCT LEFT(FirstName, 1) AS FirstLetter
FROM WizzardDeposits
WHERE DepositGroup = 'Troll Chest'
ORDER BY FirstLetter;

/* 11. Average Interest */
SELECT DepositGroup, IsDepositExpired, AVG(DepositInterest) AS AverageInterest
FROM WizzardDeposits 
WHERE DepositStartDate > '01/01/1985'
GROUP BY DepositGroup, IsDepositExpired
ORDER BY DepositGroup DESC, IsDepositExpired ASC;

/* 12. Rich Wizard, Poor Wizard */
SELECT SUM(ResultTable.[Difference]) AS SumDifference
FROM (SELECT DepositAmount - (SELECT DepositAmount FROM WizzardDeposits WHERE Id = w.Id + 1) AS [Difference] FROM WizzardDeposits w) 
AS ResultTable

USE SoftUni
GO

/* 13.Departments Total Salaries */
SELECT DepartmentId, SUM(Salary) AS TotalSalary
FROM Employees
GROUP BY DepartmentID
ORDER BY DepartmentID;

/* 14. Employees Minimum Salaries */
SELECT DepartmentId, Min(Salary) AS MinimumSalary
FROM Employees
WHERE DepartmentID IN (2, 5, 7) AND HireDate > '01/01/2000'
GROUP BY DepartmentID;

/* 15. Employees Average Salaries */
SELECT * INTO EarnMoreThan30000
FROM Employees
WHERE Salary > 30000;

DELETE FROM EarnMoreThan30000
WHERE ManagerId = 42;

UPDATE EarnMoreThan30000
SET Salary += 5000
WHERE DepartmentID = 1;

SELECT DepartmentId, AVG(Salary) AS AverageSalary
FROM EarnMoreThan30000
GROUP BY DepartmentId;

/* 16. Employees Maximum Salaries */
SELECT DepartmentId, MAX(Salary) AS MaxSalary
FROM Employees 
GROUP BY DepartmentID
 HAVING MAX(Salary) NOT BETWEEN 30000 AND 70000;

 /* 17. Employees Count Salaries */
 SELECT COUNT(Salary) AS [Count]
 FROM Employees
 WHERE ManagerID IS NULL;