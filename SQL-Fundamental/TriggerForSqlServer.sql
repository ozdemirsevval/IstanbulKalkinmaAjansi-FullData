select top 10 * from [Order Details]
select * from Products where ProductID=51

-- Sql Server'da trigger Insert,Update ve delete işlemlerinden önce yada sonra çalışan yapılardır.
-- Sql server 2 adet sanal tablo ile çalışır.
-- yeni gelen kayıtlar inserted tablosunda tutulur 
-- silinen kayıtlar ise deleted tablosunda tutulur.
-- Bu sanal tablolar hafızadadır. Tales sekmesi içerisinde görünmezler.
-- insert sirasinda olusan kayitlar inserted tablosunda tutulur.
-- Update islemi sirada olusan kayitlar ise , yeni gelen kayit inserted tablosunda
-- silinen kayit yani eski hali deleted tablosunda tutulur. 
-- kayit silme isleminde ise silinen kayitlar deleted tablosunda tutulur.





-- Trigger yazalım.

CREATE TRIGGER StokKontrol 
ON [Order Details]
After Insert
AS
BEGIN
      -- order details tablosuna gelen kayıtlları inserted tablosundan alalım.
DECLARE @productid int @quantity int, @eldekiStok int,@productName nvarchar(40)

SELECT @productid=i.ProductID, @quantity=i.Quantity from inserted AS i

-- product tablosuna bakılacak

SELECT @eldekiStok = UnitsInStock, @productName = ProductName from Products where ProductID=@productid

if(@eldekiStok < @quantity)

END