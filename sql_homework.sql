1)
SELECT
    OrderID, ProductName
FROM
    OrderDetails
INNER JOIN Products ON
    OrderDetails.ProductID = Products.ProductID
WHERE ProductName = 'Chang';

2)
SELECT c.CustomerName FROM Customers c WHERE c.CustomerID IN
( SELECT o.CustomerID FROM Orders o WHERE o.OrderID IN
( SELECT
    od.OrderID
FROM
    OrderDetails od
INNER JOIN Products p ON
    od.ProductID = p.ProductID
WHERE ProductName = 'Chais' ));

3)
SELECT c.CustomerName FROM Customers c WHERE c.CustomerID IN (
select  CustomerID
from    Orders
group by
        CustomerID
having  count(*) > 1);

4)
SELECT C.CustomerID, C.CustomerName, SUM(OD.Quantity * P.PRICE) AS TotalOrderPrice
FROM Customers AS C
JOIN ORDERS AS O ON C.CustomerID = O.CustomerID
JOIN ORDERDETAILS AS OD ON O.OrderID = OD.OrderID
JOIN PRODUCTS AS P ON P.ProductID = OD.ProductID
GROUP BY C.CustomerID
HAVING TotalOrderPrice > 500
ORDER BY C.CustomerID
