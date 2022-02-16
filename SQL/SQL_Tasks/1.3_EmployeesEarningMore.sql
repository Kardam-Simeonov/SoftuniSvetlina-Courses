CREATE TABLE Employee(
	ID int PRIMARY KEY,
	[Name] varchar(50),
	Salary money,
	ManagerID int
);
	
SELECT Employee.[Name] FROM Employee
INNER JOIN Employee as Manager ON Employee.ID = Manager.ManagerID
WHERE Employee.Salary > Manager.Salary;