--Like Komutu

--ürün adýnýn herhangi bir yerinde i harfi geçen ürünleri listeleyin.
select * from Products where ProductName like '%i'

--% iþareti hepsini temsil eder eðer 2 adet % iþareti ve arasýnda kelime/karakter varsa öncesi ve sonrasý önemli deðil içinde belirtilen kelime/karakter geçenleri getirir.

--3. karakteri a olan ürünleri listeleyin.

select * from Products where ProductName like '__a%'

--3. karakteri a olmayan ürünleri listeleyin.

--I. YOL
select * from Products where ProductName not like '__a%'

--II.YOL
select * from Products where ProductName like '__[^a]%'

------------------------------------------------------------------

--3.karakteri a olmayan ve 2. karakteri c olan ürünleri listeleyin.
--I.YOL
select * from Products Where ProductName not like '__a%' and ProductName like '_c%'
--II.Yol
select * from Products Where ProductName like '_c[^a]%'

-----------------------------------------------

--Sipariþler tablosunda sipariþin taþýnma zamaný girilmemiþ kayýtlarý listeleyin.

select * from Orders where ShippedDate is null


--Japonca bilen personelim kimdir?
--Yasin
--Burcu
--ahmet sait
--ahmet çavuþ

select * from Employees where Notes like '%japanese%'




