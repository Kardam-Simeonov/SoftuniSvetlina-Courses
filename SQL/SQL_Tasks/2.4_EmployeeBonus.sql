SELECT Employee.name, Bonus.bonus
FROM Employee
INNER JOIN Bonus ON Employee.empId = Bonus.empId
WHERE Bonus.bonus < 1000;