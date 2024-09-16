-- Bu Bölümdeki Genel Hatlar: Toplama, Gruplama, Sayma Fonksiyonları

-- COUNT => Verilen Değere Göre Bir Tablodaki Kayıt Sayısını Bulur.
-- Count, Null değerleri saymaz.

Select Count(*) from Employees -- Tablodaki kayıt sayısı,9.
Select Count(Region)from Employees  -- 5 kayıt : null değerleri saymaz.
SELECT * From Employees Where Region is null
Select Count(distinct country)from Employees -- 2 kayıt, USA,UK
/*
  DISTINCT: Bu anahtar kelime, yalnızca benzersiz (tekrarsız) değerleri almanızı sağlar. 
  Burada, country sütunundaki tekrar eden değerleri filtreler.
*/

-- SUM :SUM fonksiyonu, bir sütundaki sayısal değerlerin toplamını hesaplamak için kullanılır.

Select sum(unitprice)from products -- Tüm ürünlerin birim fiyat toplamı : 2222,71 
-- Çalışanların doğum yıllarının ortalaması
SELECT SUM(DATEPART(year,BirthDate))/COUNT(*) From Employees -- 1955
-- Çalışanların yaş ortalamasını hesaplayalım.
Select SUM(DATEDIFF(year,BirthDate,CURRENT_TIMESTAMP))/Count(*)
AS YasOrtalamasi from Employees; --68

-- AVG: AVG fonksiyonu, bir sütundaki sayısal değerlerin ortalamasını hesaplamak için kullanılır.

-- Çalışanların yaş ortalamasını hesaplayalım, avg ile
Select AVG(DATEDIFF(year,BirthDate,CURRENT_TIMESTAMP))AS YasOrtalamasi from Employees;
--DATEDIFF(year,BirthDate,CURRENT_TIMESTAMP) > Burda yapılan işlem yaş hesabı.

-- / Yuvarlama /
-- Yukarı Yuvarlama --
-- CEILING : CEILING fonksiyonu, bir sayıyı bir üst tam sayıya yuvarlar. 
-- Yani, bir sayı küsuratlı ise, bu sayı yukarı doğru en yakın tam sayıya yuvarlanır.
Select Ceiling(10.5) -- 11
Select Ceiling(11.5) -- 12
Select Ceiling(15.1) -- 16
Select Ceiling(11.6) -- 12
Select Ceiling(12.51) -- 13
Select Ceiling(13.49) -- 14
Select Ceiling(14.734) -- 15

-- Aşağı Yuvarlama -- 
-- FLOOR : LOOR fonksiyonu, verilen sayıyı en yakın tam sayıya yuvarlar 
-- ve bu tam sayı verilen sayıdan küçük veya eşit olur.
Select FLOOR(10.9) -- 10
Select FLOOR(12.9463) -- 12
Select FLOOR(11.312) -- 11
Select FLOOR(15.5389) -- 15
Select FLOOR(14.1) -- 14
Select FLOOR(13.9) -- 13
Select FLOOR(289.0834) -- 289

-- Normal Yuvarlama --
-- ROUND :  ROUND fonksiyonu, bir sayıyı belirtilen hassasiyete göre yuvarlamak için kullanılır.
/* Söz dizimi : ROUND(expression, precision)
  Expression : Yuvarlanacak sayıyı belirtir. Bu bir sayısal ifade olabilir (örneğin, 10.5678).
  Precision : Yuvarlama hassasiyetini belirtir. Bu, kaç ondalık basamağa yuvarlanacağını belirtir. 
  Pozitif bir değer, ondalık basamak sayısını belirtirken; 
  negatif bir değer, sayının tam sayı kısmındaki basamak sayısını belirtir.
*/
SELECT ROUND(1020.5678,2); -- Değerini iki ondalık basamağa yuvarlar, 1020.5700
SELECT ROUND(1020.5678,-2); -- Değeri en yakın yüzlüğe yuvarlar, 1000. --23 ağustos ders kaydında kaldın.

