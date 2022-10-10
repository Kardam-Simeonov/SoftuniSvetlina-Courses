USE [Bank]
SELECT [Id], [FirstName], [LastName], LEFT([PaymentNumber], 6) + '**********' FROM [Customers]

USE [Logistics]
SELECT [Id], [Name], [Quantity], [BoxCapacity], [PalletCapacity], 
		CEILING(
			CAST([Quantity] AS float) / [BoxCapacity] / [PalletCapacity])
		AS [Number of pallets] FROM [Products]

SELECT [InvoiceId], [Total],
	DATEPART(QUARTER, [InvoiceDate]) AS Quarter,
	DATEPART(MONTH, [InvoiceDate]) AS Month,
	DATEPART(YEAR, [InvoiceDate]) AS Year,
	DATEPART(DAY, [InvoiceDate]) AS Day
FROM [Invoices]