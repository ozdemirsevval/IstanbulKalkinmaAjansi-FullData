CREATE OR REPLACE PROCEDURE CalisanlarinPerformansi(yil INT)
LANGUAGE plpgsql
AS $$ 
DECLARE 
employee_record Record;
BEGIN
FOR employee_record IN
Select E.first_name || ' ' || E.last_name AS Employee,
SUM(OD.Quantity*OD.Unit_Price*(1-Discount))Ciro 
FROM Employees AS E 
Inner Join orders as O on E.employee_id = o.employee_id
INNER JOIN Order_Details as OD on OD. Order_ID = O.Order_ID
WHERE date_part('year',O.order_date) = yil
Group by E.First_Name , E.Last_Name 
Order by Ciro Desc
 LOOP
        RAISE NOTICE 'Employee: %, Ciro: %', employee_record.Employee, employee_record.Ciro;
    END LOOP;
END;
$$;

Call CalisanlarinPerformansi (1997);