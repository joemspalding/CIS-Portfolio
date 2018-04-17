--1
--List the products with a list price greater than the average list price of all products.
SELECT	ItemID, Description, ListPrice
FROM	PET..Merchandise
WHERE	ListPrice > (SELECT AVG(ListPrice)
					 FROM PET..Merchandise
					)

--2
--Which merchandise items have an average sale price more than 50% higher than their average purchase cost?
--SUBQUERY WAY
--SELECT	DISTINCT M.ItemID,
--		(SELECT AVG(Cost)  FROM PET..OrderItem  WHERE ItemID = M.ItemID) AS [AverageCost], 
--		(SELECT AVG(SalePrice)  FROM PET..SaleItem  WHERE ItemID = M.ItemID) AS [AverageSalePrice]
--FROM	PET..SaleItem S INNER JOIN PET..Merchandise M ON S.ItemID = M.ItemID
--		INNER JOIN PET..OrderItem O ON M.ItemID = O.ItemID
--WHERE	1.5*(SELECT AVG(Cost)  FROM PET..OrderItem  WHERE ItemID = M.ItemID) < (SELECT AVG(SalePrice)  FROM PET..SaleItem  WHERE ItemID = M.ItemID)

--GROUPBY, HAVING WAY
SELECT	DISTINCT M.ItemID,
		(SELECT AVG(Cost)  FROM PET..OrderItem  WHERE ItemID = M.ItemID) AS [AverageCost], 
		(SELECT AVG(SalePrice)  FROM PET..SaleItem  WHERE ItemID = M.ItemID) AS [AverageSalePrice]
FROM	PET..SaleItem S INNER JOIN PET..Merchandise M ON S.ItemID = M.ItemID
		INNER JOIN PET..OrderItem O ON M.ItemID = O.ItemID
GROUP BY M.ItemID
HAVING	AVG(SalePrice) > 1.5 * AVG(Cost)

--3
--List the employees and their total merchandise sales expressed as a percentage of total merchandise sales for all employees.
CREATE VIEW TOTSALES AS
SELECT	EmployeeID, SUM(SI.SalePrice*SI.Quantity) AS [TotalSales]
FROM	PET..SALE S INNER JOIN PET..SaleItem SI ON S.SaleID = SI.SaleID
GROUP BY EmployeeID

SELECT	DISTINCT E.EmployeeID, E.LastName, T.TotalSales,
		(T.TotalSales/(SELECT SUM(SalePrice*Quantity)  FROM PET..SaleItem))*100 AS [PctSales]
FROM	PET..Employee E INNER JOIN TOTSALES T ON E.EmployeeID = T.EmployeeID
ORDER BY E.EmployeeID

DROP VIEW TOTSALES

--4
--On average, which supplier charges the highest shipping cost as a percent of the merchandise order total?
CREATE VIEW FINDTOP AS
SELECT	DISTINCT  M.PONumber, AVG(M.ShippingCost)/(SUM(O.Cost*O.Quantity) + M.ShippingCost)*100 AS [TopPrct]
FROM	PET..MerchandiseOrder M INNER JOIN PET..OrderItem O ON M.PONumber = O.PONumber
GROUP BY M.PONumber, M.ShippingCost

SELECT	S.SupplierID, S.Name, T.TopPrct
FROM	PET..Supplier S INNER JOIN PET..MerchandiseOrder M ON S.SupplierID = M.SupplierID 
		INNER JOIN FINDTOP T ON M.PONumber = T.PONumber
WHERE	(SELECT TOP 1 T.PONumber
		 FROM	FINDTOP
		 HAVING	MAX(TopPrct) = T.TopPrct
		) = M.PONumber

DROP VIEW FINDTOP

--5
--Which customer has given us the most total money for animals and merchandise?
--VIEW HEAVY METHOD
--CREATE VIEW MERCSALE AS
--SELECT DISTINCT S.CustomerID, SUM(SI.SalePrice * SI.Quantity) AS [MercTotal]
--FROM PET..Sale S INNER JOIN PET..SaleItem SI ON S.SaleID = SI.SaleID
--GROUP BY S.CustomerID

--CREATE VIEW ANIMALSALE AS
--SELECT DISTINCT S.CustomerID, SUM(SA.SalePrice) AS [AnimalTotal]
--FROM PET..Sale S INNER JOIN PET..SaleAnimal SA ON S.SaleID = SA.SaleID
--GROUP BY S.CustomerID

--CREATE VIEW TOTALSALE AS
--SELECT	A.CustomerID, MercTotal , AnimalTotal, MercTotal + AnimalTotal AS [GrandTotal]
--FROM	ANIMALSALE A INNER JOIN MERCSALE M ON A.CustomerID = M.CustomerID
--GROUP BY A.CustomerID, A.AnimalTotal, M.MercTotal

--SELECT	TOP 1 C.CustomerID, C.LastName, C.FirstName, T.MercTotal, T.AnimalTotal, T.GrandTotal
--FROM	TOTALSALE T INNER JOIN PET..Customer C ON T.CustomerID = C.CustomerID
--ORDER BY T.GrandTotal DESC

--DROP VIEW MERCSALE, ANIMALSALE, TOTALSALE

--VIEWLESS METHOD
SELECT	TOP 1 S.CustomerID, C.LastName, C.FirstName,
		--MERCHANDISE TOTAL CALCULATION
		(SELECT DISTINCT SUM(SI1.SalePrice * SI1.Quantity)
		 FROM	PET..Sale S1 INNER JOIN PET..SaleItem SI1 ON S1.SaleID = SI1.SaleID
		 WHERE	S.CustomerID = S1.CustomerID
		 GROUP BY S1.CustomerID) AS [MercTotal],
		--ANIMAL TOTAL CALCULATION
		(SELECT DISTINCT SUM(SA1.SalePrice) AS [AnimalTotal]
		 FROM	PET..Sale S1 INNER JOIN PET..SaleAnimal SA1 ON S1.SaleID = SA1.SaleID
		 WHERE	S.CustomerID = S1.CustomerID
		 GROUP BY S1.CustomerID) AS [AnimalTotal],
		--GRAND TOTAL CALCULATION
		(SELECT DISTINCT SUM(SI1.SalePrice * SI1.Quantity)
		 FROM	PET..Sale S1 INNER JOIN PET..SaleItem SI1 ON S1.SaleID = SI1.SaleID
		 WHERE	S.CustomerID = S1.CustomerID
		 GROUP BY S1.CustomerID) + 
		(SELECT DISTINCT SUM(SA1.SalePrice) AS [AnimalTotal]
		 FROM	PET..Sale S1 INNER JOIN PET..SaleAnimal SA1 ON S1.SaleID = SA1.SaleID
		 WHERE	S.CustomerID = S1.CustomerID
		 GROUP BY S1.CustomerID) AS [GrandTotal]
		--END SELECT
FROM	PET..Sale S INNER JOIN PET..Customer C ON S.CustomerID = C.CustomerID
GROUP BY S.CustomerID, C.LastName, C.FirstName
ORDER BY GrandTotal DESC

--6
--Which customers who bought more than $100 in merchandise in May also spent more than $50 on merchandise in October
SELECT	DISTINCT C.CustomerID, C.LastName, C.FirstName, (SELECT	SI.SalePrice
														 FROM	PET..Sale S INNER JOIN PET..SaleItem SI ON S.SaleID = SI.SaleID
														 WHERE	SI.SalePrice > 100 AND
																MONTH(SaleDate) = 5
														) AS [MayTotal]
FROM	PET..Customer C INNER JOIN PET..Sale S ON C.CustomerID = S.CustomerID
		INNER JOIN PET..SaleItem SI ON S.SaleID = SI.SaleID
WHERE	S.CustomerID IN (SELECT	S.CustomerID
		 FROM	PET..Sale S INNER JOIN PET..SaleItem SI ON S.SaleID = SI.SaleID
		 WHERE	SI.SalePrice > 100 AND
				MONTH(SaleDate) = 5
		) 
		AND
		S.CustomerID IN (SELECT	S.CustomerID
		FROM	PET..Sale S INNER JOIN PET..SaleItem SI ON S.SaleID = SI.SaleID
		WHERE	SI.SalePrice > 50 AND
				MONTH(SaleDate) = 10
		)

--7
--What was the net change in quantity on hand for premium canned dog food between Jan 1 and Jul 1?
SELECT	DISTINCT M.Description, M.ItemID, 
		(SELECT SUM(Quantity)  FROM PET..OrderItem  WHERE ItemID = 16) AS [Purchased], 
		(SELECT SUM(Quantity)  FROM PET..SaleItem  WHERE ItemID = 16) AS [Sold], 
		(SELECT SUM(Quantity)  FROM PET..OrderItem  WHERE ItemID = 16) -
		(SELECT SUM(Quantity)  FROM PET..SaleItem  WHERE ItemID = 16) AS [NetIncrease]
FROM	PET..Merchandise M INNER JOIN PET..SaleItem SI ON M.ItemID = SI.ItemID
		INNER JOIN PET..Sale S ON SI.SaleID = S.SaleID
WHERE	M.ItemID = 16 AND
		(MONTH(SaleDate) >= 1 AND MONTH(SaleDate) <= 7)

--8
--Which merchandise items with a list price more than $50 had no sales July?
SELECT	DISTINCT M.ItemID, M.Description, M.ListPrice
FROM	PET..Merchandise M INNER JOIN PET..SaleItem SI ON M.ItemID = SI.ItemID
		INNER JOIN PET..Sale S ON SI.SaleID = S.SaleID
WHERE	M.ListPrice > 50 AND
		SI.ItemID NOT IN
			(SELECT	ItemID
			 FROM	PET..SaleItem
			 WHERE	MONTH(S.SaleDate) = 7 
			)

--9
--Which merchandise items with more than 100 units on hand have not been ordered in 2004? Use an outer join to answer the question.
SELECT	M.ItemID, M.Description, M.QuantityOnHand, O.ItemID
FROM	PET..OrderItem O FULL OUTER JOIN PET..Merchandise M ON O.ItemID = M.ItemID
		FULL OUTER JOIN PET..MerchandiseOrder MO ON O.PONumber = MO.PONumber
WHERE	M.QuantityOnHand > 100 AND 
		(O.PONumber IS NULL OR
		 O.PONumber NOT IN (SELECT	PONumber
						   FROM		PET..MerchandiseOrder
						   WHERE	YEAR(OrderDate) = 2004)
		)

--10
--Which merchandise items with more than 100 units on hand have never been ordered in 2004? Use a subquery to answer the question.
SELECT	M.ItemID, M.Description, M.QuantityOnHand
FROM	PET..Merchandise M LEFT OUTER JOIN PET..OrderItem O ON M.ItemID = O.ItemID
		LEFT OUTER JOIN PET..MerchandiseOrder MO ON O.PONumber = MO.PONumber
WHERE	M.QuantityOnHand > 100 AND
		(M.ItemID NOT IN (SELECT ItemID  FROM PET..OrderItem) OR
		 O.PONumber NOT IN (SELECT	PONumber
						   FROM		PET..MerchandiseOrder
						   WHERE	YEAR(OrderDate) = 2004)
		)
--11
--Save a query to list the total amount of money spent by each customer. Create the table shown to categorize customers based on sales. 
--Write a query to displays the proper label. Must only use SQL statements and include all statements in the proper order.
-- | CATEGORY |   LOW    |   HIGH   |
-- |   WEAK   |    0     |   200    |
-- |   GOOD   |   200    |   800    |
-- |   BEST   |   800    |  10000   |

CREATE TABLE Categorize 
		(Category	VARCHAR(50),
		 LowEnd		INT,
		 HighEnd	INT
		)

INSERT INTO Categorize
VALUES	('Weak', 0, 200),
		('Good', 200, 800),
		('Best', 800, 10000)

CREATE VIEW SOLVER AS
SELECT DISTINCT S.CustomerID, S.SaleID, SA.SalePrice
FROM PET..Sale S INNER JOIN PET..SaleAnimal SA ON S.SaleID = SA.SaleID
UNION
SELECT DISTINCT S.CustomerID, S.SaleID,
		(SELECT SUM(SalePrice * Quantity)
		 FROM PET..SaleITEM
		 WHERE SI.SaleID = SaleID 
		 ) AS [SalePrice]
FROM PET..Sale S INNER JOIN PET..SaleItem SI ON S.SaleID = SI.SaleID

SELECT	DISTINCT S.CustomerID, C.LastName, C.FirstName,
		(SELECT SUM(SalePrice) FROM SOLVER  WHERE S.CustomerID = CustomerID) AS [GrandTotal],
		(SELECT Category  
		 FROM Categorize  
		 WHERE (SELECT SUM(SalePrice)  FROM SOLVER  WHERE S.CustomerID = CustomerID) >= LowEnd AND
			   (SELECT SUM(SalePrice)  FROM SOLVER  WHERE S.CustomerID = CustomerID) < HighEnd) AS [Category] 
FROM	SOLVER S INNER JOIN PET..Customer C ON S.CustomerID = C.CustomerID

DROP VIEW SOLVER
DROP TABLE Categorize

--12
--List all suppliers (animals and merchandise) who sold us items in June. Identify whether they sold use animals or merchandise.
SELECT	DISTINCT S.SupplierID, S.Name, 'Animal' AS [OrderType]
FROM	PET..Supplier S FULL JOIN PET..AnimalOrder A ON S.SupplierID = A.SupplierID
		FULL JOIN PET..MerchandiseOrder M ON S.SupplierID = M.SupplierID
WHERE	A.OrderID IS NOT NULL AND
		MONTH(A.OrderDate) = 6
UNION
SELECT	DISTINCT S.SupplierID, S.Name, 'Merchandise' AS [OrderType]
FROM	PET..Supplier S FULL JOIN PET..AnimalOrder A ON S.SupplierID = A.SupplierID
		FULL JOIN PET..MerchandiseOrder M ON S.SupplierID = M.SupplierID
WHERE	M.PONumber IS NOT NULL AND
		MONTH(M.OrderDate) = 6

--DUBSTEP!
CREATE TABLE BASS (WUBWUB VARCHAR)
DROP TABLE BASS