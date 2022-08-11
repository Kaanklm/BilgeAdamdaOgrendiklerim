--Where: filitreleme (Kriter) iþlemi yapar. 


--ürün id'si 1 olaný listeyin.
select * from Products where ProductID=1

--Operatörler

/*
	> büyüktür
	< küçüktür
	>= büyük eþittir.
	<= küçük eþittir.
	<> eþit deðildir.
	!= eþit deðildir.

*/

--ürün fiyatý 30'dan büyük olanlarý listeleyin.

select * from Products where UnitPrice>30

-- Fiyatý 10 ile 40 arasýnda olan ürünleri listeleyin.

--I.Yol
select * from Products where UnitPrice>10 and UnitPrice<40

--II.Yol
select * from Products where UnitPrice between 10 and 40

--------------------------------------------------------------

--in ifadesi 10 ya da 40 olan ürünleri getirir.
select * from Products where UnitPrice in(10,40)

--------------------------------------------------------------

--stok miktarý 10'dan küçük olan ürünlerin ürün adý, fiyatý, ve stok miktarýný listeleyin.

select ProductName as 'Ürün Adý', UnitPrice as 'Fiyat', UnitsInStock as 'Stok Miktarý' from Products where UnitsInStock<10

---------------------------------------------------------------

--çalýþanlardan adý janet olan'ýn bilgilerini listeleyin.
select * from Employees where FirstName='janet'





