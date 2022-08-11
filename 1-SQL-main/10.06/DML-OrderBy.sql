--Order By

/*
	Order by komutu sorgunun sonucunu s�ralamak i�in kullan�l�r. Order by komutu tablodaki belirtilen alan veya alanalra g�re sonucu bize s�ral� olarak getirir. order by komutu ile beraber artan veya azalan �ekilde s�ralama yapmak m�mk�nd�r.
		--ascending (artan)
			--asc
		--descending (azalan)
			--desc
*/

--�r�nleri isimlerine g�re A'dan Z'ye s�ralay�n�z.
select ProductName from Products order by ProductName desc
	--�nemli=> order by komutu ile e�er s�ralama yapm�� oldu�umuz kolonun artan s�ralama ile sonucu d�nd�rmesini istiyorsak herhangi bir �ey yazmam�za gerek yok. Azalan s�ralama i�in desc yazmal�y�z.

--01.01.1996 ile 31.12.1996 aras�nda al�nan sipari�lerin Sipari� Id, sipari� tarihi, �lke, �ehir bilgilerini tarih kolonuna g�re �oktan az'a do�ru s�ralay�n�z.

--I.YOL
select OrderID,OrderDate,ShipCountry,ShipCity from Orders where OrderDate between '01.01.1996' and '12.31.1996' order by OrderDate desc

--II.YOL
select OrderID,OrderDate,ShipCountry,ShipCity from Orders where OrderDate>='01.01.1996' and OrderDate<='12.31.1996' order by OrderDate desc
-----------------------------------------------------------------------

--�al��anlar�n adlar�n�, soyadlar�n� ve ya�lar�n� listeleyin. Ya�lar�n� az'dan �ok'a do�ru listeleyin.

select FirstName,LastName,YEAR(GETDATE())-YEAR(BirthDate) as 'Ya�' from Employees order by Ya� asc


--�nvan� Mr. veya Dr. olanlar� isimlerine g�re �oktan aza do�ru s�ralay�n�z.

--I.YOL
select FirstName,TitleOfCourtesy from Employees where TitleOfCourtesy='mr.' or TitleOfCourtesy='dr.' order by FirstName desc

--II.YOL
select FirstName,TitleOfCourtesy from Employees where TitleOfCourtesy in('mr.','dr.') order by FirstName desc

--III.YOL
select FirstName,TitleOfCourtesy from Employees where TitleOfCourtesy like '%mr.%' or TitleOfCourtesy like '%dr.%' order by FirstName desc

--------------------------------------------------------------------------

--1948,1955 ve 1960 y�llar�nda do�anlar� artan s�ralama ile listeleyin.

--Burcu
select FirstName, YEAR(BirthDate) as yil from Employees where  YEAR(BirthDate) ='1948' or YEAR(BirthDate) ='1955' or YEAR(BirthDate) ='1960' order by BirthDate desc


--Kadir
select FirstName,LastName, YEAR(BirthDate) as 'y�l' from Employees where Year(BirthDate) in ('1948', '1955' , '1960') order by y�l desc







