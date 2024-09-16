-- insert > kayıt ekleme
-- insert into <tablo_adi>(column1,column2..) values(value1,value2..)

SELECT*FROM order_details
insert into order_details (order_id,product_id,unit_price,quantity,discount)
                    VALUES(1000,40,25,10,0);      