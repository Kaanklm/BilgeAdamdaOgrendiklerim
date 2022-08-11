
--Aggregate Fonksiyonlar (Toplam fonksiyonlar, gruplama fonksiyonlar)

/*
	Aggreagete fonksiyonlar select ifadesiyle birlikte kullanýlan geriye tek satýr, tek sütun sonuç döndüren fonksiyonlardýr.

	1-Count() => satýr adedini sayan fonksiyondur.
	2-SUM() => toplama iþlemi yapar.
	3-AVG() => ortalamasýný alýr.
	4-MIN() => minimum deðeri verir.
	5-MAX() => maksimum deðeri verir.
*/

select * from Products

--COUNT()
--Kaç adet ürün bulunmaktadýr.
select COUNT(*) as 'Ürün Adet'from Products

--Çalýþanlarýn yaþadýklarý þehir sayýsý nedir?

select COUNT(distinct City) from Employees
-----------------------------------------------------

--SUM()
--ürünler tablosunda bulunan id'lerin toplamý kaçtýr?
select SUM(ProductID) from Products

-------------------------------------------------------

--AVG()
--ürünlerin ortalama fiyatý kaçtýr?
select AVG(UnitPrice) from Products

-------------------------------------------------------

--MIN()
--en düþük fiyatlý olan ürünün fiyatý kaçtýr?
select MIN(UnitPrice) from Products

--MAX()
select Max(UnitPrice) from Products

--------------------------------------------------------

--Þuana kadarki ciroyu bulunuz?


--Irem => 4641870
--Burcu=> 2033.95999819413
--Ibrahim => 2155
--Gökçen=> 1354337.55
--Ahmet Alibeþe=> 1354458,59

select SUM(UnitPrice*Quantity*(1-Discount)) from [Order Details]

