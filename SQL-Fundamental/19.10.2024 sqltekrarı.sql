   -- PostgreSql'de Northwind ile Sql Tekrarı--
------------------------------------------------------
-- En pahalı 5 Ürün nedir?
select * from products
order by unit_price desc
limit 5;
-- Ülkelere göre müşteri sayısı nedir?
select * from customers

select country, COUNT(*) as MusteriSayisi from customers
group by country 
order by MusteriSayisi desc

-- şehirlere göre müşteri sayısını büyükten küçüğe doğru sıralayın

select city, count(*) as MusteriSayisi from customers
group by city
order by MusteriSayisi desc

--Musteri sayisi 2'den  buyuk olan sehirlerin listesi nedir?

select customers.city, count(*) as MusteriSayisi from customers
group by customers.city
having COUNT(*) > 2
order by MusteriSayisi desc

-- --1996 yilindaki musterilerin verdigi siparis sayisi nedir?

select * from orders

select orders.customer_id, count(*) as ToplamSiparisSayisi from orders
where extract(year from orders.order_date) = 1996
group by orders.customer_id
order by customer_id asc

-- 1996 yilindaki kargocularin  taşıdıgı  siparis sayisi nedir?

select * from shippers
select * from orders

select shippers.company_name, count(*) from orders 
inner join shippers on shippers.shipper_id = orders.ship_via
WHERE extract(year from shipped_date) = 1996
group by company_name
order by count(*) asc