
--Aggregate Fonksiyonlar (Toplam fonksiyonlar, gruplama fonksiyonlar)

/*
	Aggreagete fonksiyonlar select ifadesiyle birlikte kullan�lan geriye tek sat�r, tek s�tun sonu� d�nd�ren fonksiyonlard�r.

	1-Count() => sat�r adedini sayan fonksiyondur.
	2-SUM() => toplama i�lemi yapar.
	3-AVG() => ortalamas�n� al�r.
	4-MIN() => minimum de�eri verir.
	5-MAX() => maksimum de�eri verir.
*/

select * from Products

--COUNT()
--Ka� adet �r�n bulunmaktad�r.
select COUNT(*) as '�r�n Adet'from Products

--�al��anlar�n ya�ad�klar� �ehir say�s� nedir?

select COUNT(distinct City) from Employees
-----------------------------------------------------

--SUM()
--�r�nler tablosunda bulunan id'lerin toplam� ka�t�r?
select SUM(ProductID) from Products

-------------------------------------------------------

--AVG()
--�r�nlerin ortalama fiyat� ka�t�r?
select AVG(UnitPrice) from Products

-------------------------------------------------------

--MIN()
--en d���k fiyatl� olan �r�n�n fiyat� ka�t�r?
select MIN(UnitPrice) from Products

--MAX()
select Max(UnitPrice) from Products

--------------------------------------------------------

--�uana kadarki ciroyu bulunuz?


--Irem => 4641870
--Burcu=> 2033.95999819413
--Ibrahim => 2155
--G�k�en=> 1354337.55
--Ahmet Alibe�e=> 1354458,59

select SUM(UnitPrice*Quantity*(1-Discount)) from [Order Details]

