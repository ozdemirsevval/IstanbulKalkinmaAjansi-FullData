-- Tarih sorgularında genel olarak kullanılan datepart fonksiyonu vardır.
-- MSSQL SÖZ DİZİMİ
Select*From Orders where DATEPART(year,OrderDate)=1996; 

Select*From Orders where DATEPART(year,OrderDate)=1996;
and MONTH(OrderDate)=11 and DAY(OrderDate)=26; 

SELECT DATEPART(DAYOFYEAR,GetDate()); -- 245.GÜN
SELECT GetDate(); -- Sorgunun çalıştırıldığı andaki zamanı verir.

SELECT FirstName+' '+LastName AS EmployeeName,
DATEDIFF(year,BirthDate,GETDATE()) AS AGE from Employees;
/*   
DATEDIFF, SQL Server'da iki tarih arasındaki farkı belirli bir birim 
(gün, ay, yıl, saat, dakika, saniye vb.) cinsinden hesaplayan bir fonksiyondur. 
Bu fonksiyon, iki tarih arasındaki farkı bir tam sayı olarak döndürür.
*/

--PostgreSQL SÖZ DİZİMİ
Select*From Orders where DATE_PART('year',Order_Date)=1996;
Select*From Orders where DATE_PART('month',Order_Date)=1996;
Select*From Orders where DATE_PART('day',Order_Date)=1996;

SELECT DATE_PART('doy',CURRENT_TIMESTAMP); --245.GÜN
-- Bu sorgunun amacı, günün yılın hangi günü olduğunu belirlemektir.
SELECT DATE_PART('dow',CURRENT_TIMESTAMP); -- 5 Cuma
-- Bu sorgunun amacı, günün haftanın hangi günü olduğunu belirlemektir.
-- 'dow': Bu argüman, haftanın gününü temsil eder (day of week). 
-- PostgreSQL'de 'dow' ile haftanın gününü 0 (Pazar) ile 
-- 6 (Cumartesi) arasında bir değer olarak alırsınız.
SELECT CURRENT_TIMESTAMP; -- Sorgunun çalıştırıldığı andaki tarih ve saat bilgisini döndürür. 

-- PostgreSQL'de mssql'deki gibi '+' operatörüyle stringleri birleştiremezsiniz.
-- Bunun yerine || operatörünü kullanmanız gerekir.
SELECT First_Name|| ' ' || Last_Name As EmployeeName, 
Age(CURRENT_TIMESTAMP,Birth_Date) From Employees;

SELECT now(),CURRENT_TIMESTAMP; -- anlık zaman bilgisi
SELECT LOCALTIME;
show timezone;