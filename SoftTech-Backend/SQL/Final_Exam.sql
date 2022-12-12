-- 1. Customers Orders
SELECT FirstName, LastName, COUNT(OrderId) AS Orders
FROM Orders
INNER JOIN Customers ON Orders.CustomerId = Customers.CustomerId
GROUP BY FirstName, LastName
ORDER BY Orders DESC, FirstName ASC;

-- 2. Customers and Items
SELECT FirstName, LastName, Items.[Name], Quantity
FROM Orders 
INNER JOIN Items ON Items.OrderId = Orders.OrderId
INNER JOIN Customers ON Customers.CustomerId = Orders.CustomerId
WHERE Quantity >= 5
ORDER BY Quantity DESC;

-- 3. Staff Orders
CREATE PROC usp_GetOrdersOfStaff(@staffId int)
AS
BEGIN
	SELECT Staffs.StaffId, FirstName AS [First Name], LastName AS [Last Name], COUNT(OrderId) AS [Orders Count]
	FROM Orders
	INNER JOIN Staffs ON Orders.StaffId = Staffs.StaffId
	WHERE Staffs.StaffId = @staffId
	GROUP BY Staffs.StaffId, FirstName, LastName;
END

-- 4. Delete Staff
CREATE TRIGGER tr_StaffDelete
ON Staffs
INSTEAD OF DELETE
AS
	UPDATE Staffs SET Active = 0
	WHERE StaffId IN (SELECT StaffId FROM deleted);