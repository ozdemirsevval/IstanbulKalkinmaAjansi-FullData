-- çalışanların yaptığı cire nedir(1997 yılı)
-- Eğer ki bu sorguyu parametrik hale getirmek istersek 
-- Create komutu databasede istenilen objeleri oluşturmaya yarar.

--CREATE PROCEDURE CalisanlarinPerformansi(@yil as INT)
ALTER PROCEDURE CalisanlarinPerformansi(@yil as INT)
AS
BEGIN
SELECT e.FirstName +' '+ e.LastName as Employee,Round(SUM(od.quantity*od.unitprice*(1-discount)),0) as Ciro
FROM Employees as E inner JOIN Orders as O on E.EmployeeID = O.EmployeeID
inner JOIN [Order Details] as OD on OD.OrderID = o.OrderID
where year(O.OrderDate)  = @yil
group by E.FirstName + ' ' + E.LastName
Order by Ciro DESC
END

-- procedure çağrılması/çalıştırılması

exec CalisanlarinPerformansi 1997