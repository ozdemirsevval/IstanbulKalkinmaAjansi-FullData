-- Tek satırlık yorum satırı
/*
   Çok satırlı yorum
*/

/*
              MSSQL - POSTGRE FARKLARI
  > MSSQL pascal case kullanırken PostgreSQL snakecase kullanır.
  > PotgreSQLde key sensitive varken MSSQL'de yoktur.
*/

-- Select veritabanındaki tabloları ya da view'ları sorgulamaya yarar.
-- Genel kullanımı : SELECT * FROM <tablo_adi>

-- Örnekler
-- Productları listeleyelim

SELECT * FROM products
SELECT * FROM customers;
SELECT * FROM shippers;
SELECT * FROM employees;
SELECT * FROM orders;
-- MySQL'deki LIMIT sorgusunun SQL Server'daki karşılığı TOP ifadesidir.
-- select * from orders limit 5;
-- select * from [Order Details] limit 5;
-- Bu komut, ilgli tablodan ilk 5 satırı getirir.
SELECT TOP 5 * FROM Orders;
SELECT TOP 5 * FROM [Order Details];
select * from products where ProductID=72 ;
select * from suppliers
/*
select ifadesinde * kullanilirsa tablodaki butun feild alanlari gelir.
Bu genelede tercih edilmez. Cunku fazladan network trafigine neden olur.
Bundan kacmanin yolu ihtiyac duyulan field'larin tke tek aralarinda , olmak kaydiyla belirlenmesidir.
*/
SELECT EmployeeID, FirstName,LastName FROM Employees
SELECT EmployeeID, FirstName+' '+ LastName as employeeName FROM Employees

-- Data Fitreleme :  Filteleme yapmak için where şartı kullanılır.

Select * From Customers -- Önce tabloyu incele sonra örnek sorgu yaz.

-- Amerika'daki müşterilerin listesi
SELECT * FROM Customers WHERE Country = 'USA'; -- 13 kayıt
-- Seattle'daki müşterilerin listesi
SELECT * FROM Customers WHERE Country = 'USA' AND  City = 'Seattle';
-- WHERE koşulunda birden fazla koşul belirttiğinizde, bu koşulları birleştirmek için
-- AND veya OR operatörlerini kullanılır.

-- Where şartında null kayıtların sorgulanması
SELECT * FROM Customers where Region is NULL

-- Tarih ile ilgili alanların sorgulanması (MSSQL)
SELECT * FROM Orders WHERE year(OrderDate) = 1996;
SELECT * FROM Orders WHERE month(OrderDate) = 7;
SELECT * FROM Orders WHERE day(OrderDate) = 5;
SELECT * FROM Orders Where Datepart(year,OrderDate)=1996;
/*
DATEPART fonksiyonu, SQL Server'da bir tarih veya zaman değerinden 
belirli bir bileşeni (parçası) ayıklamak için kullanılır. 
Bu bileşen, yıl, ay, gün, saat, dakika gibi farklı zaman parçaları olabilir.
*/
--PostgreSQL
SELECT * FROM orders Where date_part('year',order_date) = 1996;
SELECT * FROM orders Where date_part('month',order_date) = 7;
SELECT * FROM orders Where date_part('day',order_date) = 5;

-- Sayısal alanlarda sorgulama
SELECT * FROM Orders WHERE ship_via = 3;

-- Amerika dışındaki tedarikçilerin listesi
SELECT * FROM suppliers WHERE Country != 'USA';