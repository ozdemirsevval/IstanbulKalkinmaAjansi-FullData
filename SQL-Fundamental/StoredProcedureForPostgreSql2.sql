CREATE OR REPLACE Function Calisan_Peformansi(yil INT)
returns table (Calisan varchar, Ciro Numeric)
AS
$func$
Select E.first_name, E.last_name AS Employee,
SUM(OD.Quantity*OD.Unit_Price*(1-Discount))Ciro 
FROM Employees AS E 
Inner Join orders as O on E.employee_id = o.employee_id
INNER JOIN Order_Details as OD on OD. Order_ID = O.Order_ID
WHERE date_part('year',O.order_date) = yil
Group by E.First_Name , E.Last_Name 
Order by Ciro Desc
$func$
LANGUAGE sql;

select * from Calisan_Peformansi(1997)