--Join

--Tablolar� birbirlerine dahil ederek ortak sorgular yazmam�za olanak sa�lar.

/*
	select 
	<tablo1Adi>.<kolonAdi>
	<tablo2Adi>.<kolonAdi>
	from <tablo1Adi> inner join <tablo2Adi> on <tablo1Adi.kolonAdi>=<tablo2Adi.kolonAdi>
*/




--�al��anlar�n Id'lerine g�re alm�� olduklar� sipari�leri listeleyin.
select EmployeeID,COUNT(*) from Orders group by EmployeeID order by 2 desc

--Raporlama yaparken Id bilgileri anlaml� bilgiler de�ildir. ��nk� kim olduklar� belli de�ildir. Bu y�zden isim soyisim yaz�lmas� daha anla��l�r hale gelecektir. Tablolar� birbirlerine referans olarak (Join) ile beraber ba�lamam�z gerekmektedir.

--Employees
--Orders

select
o.OrderID,e.FirstName,e.LastName,o.OrderDate
from Orders o inner join Employees e
on o.EmployeeID=e.EmployeeID
where e.FirstName='steven'

-----------------------------------------------------------------------------------------------------

--Kategori Ad� tedarik�i firma ad� ve �r�n ad�n� getiren sorguyu yaz�n�z.
--Products (�r�nler)
--Categories (Kategoriler)
--Suppliers (Tedarik�iler)

select c.CategoryName as 'Kategori Ad�',s.CompanyName as 'Tedarik�i', p.ProductName as '�r�n' from Products p
inner join Categories c on p.CategoryID=c.CategoryID
inner join Suppliers s on p.SupplierID=s.SupplierID

------------------------------------------------------------------------------------------------------

--Federal shipping ile ta��nm�� ve nancy �zerine kay�tl� olan sipari�larin �al��an ad� ve soyad�, m��teri �irket ad�, sipari� tarihi ve kargo �cretini listeleyin.

--employees
--shippers
--orders
--customers
select (e.FirstName+' '+e.LastName) as '�al��an',
c.CompanyName as 'M��teri',
o.OrderDate as 'Sipari� Tarihi', 
o.Freight as 'Kargo �cret' 
from Orders o
inner join Employees e on o.EmployeeID=e.EmployeeID
inner join Customers c on o.CustomerID=c.CustomerID
inner join Shippers s on o.ShipVia=s.ShipperID
where s.CompanyName='federal shipping' and e.FirstName='nancy'

-------------------------------------------------------------------------------------------------------

--Hangi �lkelere ne kadarl�k sat�� yap�lm��t�r? (�lkelere g�re kazan�lan net �cret)

select top 3 o.ShipCountry as '�lke',SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) as 'Toplam Gelir' from Orders o
inner join [Order Details] od on o.OrderID=od.OrderID
group by o.ShipCountry
order by 2 desc

--------------------------------------------------------------------------------------------------------

--Hangi personel hangi kategoriden toplamda ka� adet �r�n sat��� yapm��t�r.

--�al��an ad� ve soyad�
--Kategori ad�
--Toplam sat�� adet

select (e.FirstName+' '+e.LastName) as '�al��an', ct.CategoryName as 'Kategori',SUM(od.Quantity) as 'Toplam Adet' from Employees e
inner join Orders o on e.EmployeeID=o.EmployeeID
inner join [Order Details] od on o.OrderID=od.OrderID
inner join Products p on od.ProductID=p.ProductID
inner join Categories ct on p.CategoryID=ct.CategoryID
group by (e.FirstName+' '+e.LastName),ct.CategoryName

-------------------------------------------------------------------------------------------------------


--hangi �al��an hangi �al��ana ba�l�d�r?

select calisan.FirstName as '�al��an',mudur.FirstName as 'M�d�r' from Employees calisan
inner join Employees mudur on calisan.ReportsTo=mudur.EmployeeID

--Kahveyi kazanan Irem


