--Group by

/*
	Group by komutu tablodaki ortak verilerin gruplanarak dönmesini saðlar. Group by kullanýmýndan önce gruplanacak olan alanlar belirlenip daha sonra o alanlara göre bir select sorgusu gerçekleþtirilir.
*/

--hangi kategoriden kaç adet ürün vardýr?

select CategoryId, COUNT(CategoryID) as 'Adet' from Products group by CategoryID

--Not: Aggregate function haricinde kalan bütün kolonlar group by içerisinde kullanýlýr.

--Ülkelere göre çalýþan sayýsýný listeleyin.
select Country,COUNT(Country) as 'Kiþi Sayýsý' from Employees group by Country

--Stokta hangi kategoriden toplam ne kadarlýk ürün vardýr?
select CategoryID,SUM(UnitPrice*UnitsInStock) from Products group by CategoryID

--Order by
select CategoryID,SUM(UnitPrice*UnitsInStock) as 'Toplam' from Products group by CategoryID order by Toplam desc
