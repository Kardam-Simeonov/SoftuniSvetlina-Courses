SELECT [Name] FROM Customers
LEFT JOIN Orders ON Customers.ID = Orders.CustomerID
WHERE CustomerID IS NULL;