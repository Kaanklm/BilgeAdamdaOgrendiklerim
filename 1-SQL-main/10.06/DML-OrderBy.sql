--Order By

/*
	Order by komutu sorgunun sonucunu sıralamak için kullanılır. Order by komutu tablodaki belirtilen alan veya alanalra göre sonucu bize sıralı olarak getirir. order by komutu ile beraber artan veya azalan şekilde sıralama yapmak mümkündür.
		--ascending (artan)
			--asc
		--descending (azalan)
			--desc
*/

--ürünleri isimlerine göre A'dan Z'ye sıralayınız.
select ProductName from Products order by ProductName desc
	--Önemli=> order by komutu ile eğer sıralama yapmış olduğumuz kolonun artan sıralama ile sonucu döndürmesini istiyorsak herhangi bir şey yazmamıza gerek yok. Azalan sıralama için desc yazmalıyız.

--01.01.1996 ile 31.12.1996 arasında alınan siparişlerin Sipariş Id, sipariş tarihi, ülke, şehir bilgilerini tarih kolonuna göre çoktan az'a doğru sıralayınız.

--I.YOL
select OrderID,OrderDate,ShipCountry,ShipCity from Orders where OrderDate between '01.01.1996' and '12.31.1996' order by OrderDate desc

--II.YOL
select OrderID,OrderDate,ShipCountry,ShipCity from Orders where OrderDate>='01.01.1996' and OrderDate<='12.31.1996' order by OrderDate desc
-----------------------------------------------------------------------

--Çalışanların adlarını, soyadlarını ve yaşlarını listeleyin. Yaşlarını az'dan çok'a doğru listeleyin.

select FirstName,LastName,YEAR(GETDATE())-YEAR(BirthDate) as 'Yaş' from Employees order by Yaş asc


--Ünvanı Mr. veya Dr. olanları isimlerine göre çoktan aza doğru sıralayınız.

--I.YOL
select FirstName,TitleOfCourtesy from Employees where TitleOfCourtesy='mr.' or TitleOfCourtesy='dr.' order by FirstName desc

--II.YOL
select FirstName,TitleOfCourtesy from Employees where TitleOfCourtesy in('mr.','dr.') order by FirstName desc

--III.YOL
select FirstName,TitleOfCourtesy from Employees where TitleOfCourtesy like '%mr.%' or TitleOfCourtesy like '%dr.%' order by FirstName desc

--------------------------------------------------------------------------

--1948,1955 ve 1960 yıllarında doğanları artan sıralama ile listeleyin.

--Burcu
select FirstName, YEAR(BirthDate) as yil from Employees where  YEAR(BirthDate) ='1948' or YEAR(BirthDate) ='1955' or YEAR(BirthDate) ='1960' order by BirthDate desc


--Kadir
select FirstName,LastName, YEAR(BirthDate) as 'yıl' from Employees where Year(BirthDate) in ('1948', '1955' , '1960') order by yıl desc







