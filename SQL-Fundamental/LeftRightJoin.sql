-- Hiç spiariş vermemiş müşterilerim kimdir?

SELECT C.CompanyName, count(O.OrderID) as Adet
FROM Customers as C 
left join Orders as O on C.CustomerID = O.CustomerID
GROUP BY C.CompanyName having Count(o.OrderID) = 0