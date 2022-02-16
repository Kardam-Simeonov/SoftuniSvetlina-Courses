SELECT [Name] FROM Customers
OUTER JOIN Orders ON Customers.ID = Orders.CustomerID;