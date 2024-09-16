-- Like kullanımı: Where şartından sonra kullanılır.

-- isminin içinde m olan çalışanlar(PostgreSQL)
select * from employees where first_name like '%m%' --key sensitive'dir bu şekilde sorgu çalışmaz.
--key sensitive'i kaldırmak için LIKE yerine ILIKE komutu yazılmalı
SELECT * FROM employees where first_name ILIKE '%m%'

-- MSSQL'de böyle bir key sensitive durumu yoktur.
SELECT * FROM Employees WHERE FirstName LIKE '%m%' -- Doğrudan bu şekilde çalışır.

-- ismi A ile başlayan çalışanlar
SELECT * FROM Employees WHERE FirstName LIKE 'a%'; -- 2 kayıt geldi ; Andrew ve Anne.

-- ismi A ile biten çalışanlar
SELECT * FROM  Employees WHERE FirstName LIKE '%a' -- 1 kayıt varmış, Laura.

-- ismi içinde S olan çalışanlar
SELECT * FROM Employees WHERE FirstName like '%s%' -- 1 kayıt geldi, Steven.

-- isminin ilk harfi R ikinci harfi önemli değil üçüncü harbi B olan çalışanlar
SELECT * FROM Employees Where FirstName like 'r_b%' -- 1 kayıt geldi, Robert King.

-- Çalışan notlarında italian ifadesi geçen çalışanları filtrele.
SELECT * FROM Employees WHERE Notes like '%Italian%'

SELECT * FROM Employees WHERE Notes like '%turkish%' -- yokmuş :/

-- Adının ilk harfi A ya da L olan çalışanlar
SELECT * FROM Employees WHERE FirstName LIKE 'a%' or FirstName like 'l%'
SELECT * FROM Employees WHERE FirstName LIKE '[al]%' -- Bu sql server'a özgü söz dizimidir.

-- PostgreSQL için adının ilk harfi A ya da L olan çalışanlar
SELECT * FROM Employees WHERE First_Name LIKE '[AL]%' -- bu çalışmıyor
SELECT * FROM Employees WHERE First_Name LIKE 'A%' or First_Name like 'L%'
SELECT * FROM Employees WHERE First_Name SIMILAR TO '[AL]%'

-- Adının içinde A ya da L harfi  olan çalışanlar
SELECT * FROM Employees WHERE First_Name SIMILAR TO '%A%' or First_Name SIMILAR TO'%R%'

-- ismi alfabetik olarak J-R aralığındaki harflerden başlayan çalışanlar
SELECT * FROM Employees WHERE UPPER(First_Name) SIMILAR TO '[J-R]%'
ORDER BY First_Name 

-- MSSQL'den devam
-- ismi alfabetik olarak J-R aralığındaki harflerden başlayan çalışanlar
SELECT * FROM Employees WHERE FirstName LIKE '[J-R]%'
ORDER BY FirstName 

-- Adının içinde A ya da L harfi  olan çalışanlar
SELECT * FROM Employees WHERE FirstName LIKE '%A%' or FirstName like '%L%'