--Join

--Tablolarý birbirlerine dahil ederek ortak sorgular yazmamýza olanak saðlar.

/*
	select 
	<tablo1Adi>.<kolonAdi>
	<tablo2Adi>.<kolonAdi>
	from <tablo1Adi> inner join <tablo2Adi> on <tablo1Adi.kolonAdi>=<tablo2Adi.kolonAdi>
*/




--Çalýþanlarýn Id'lerine göre almýþ olduklarý sipariþleri listeleyin.
select EmployeeID,COUNT(*) from Orders group by EmployeeID order by 2 desc

--Raporlama yaparken Id bilgileri anlamlý bilgiler deðildir. Çünkü kim olduklarý belli deðildir. Bu yüzden isim soyisim yazýlmasý daha anlaþýlýr hale gelecektir. Tablolarý birbirlerine referans olarak (Join) ile beraber baðlamamýz gerekmektedir.

--Employees
--Orders

select
o.OrderID,e.FirstName,e.LastName,o.OrderDate
from Orders o inner join Employees e
on o.EmployeeID=e.EmployeeID
where e.FirstName='steven'

-----------------------------------------------------------------------------------------------------

--Kategori Adý tedarikçi firma adý ve ürün adýný getiren sorguyu yazýnýz.
--Products (Ürünler)
--Categories (Kategoriler)
--Suppliers (Tedarikçiler)

select c.CategoryName as 'Kategori Adý',s.CompanyName as 'Tedarikçi', p.ProductName as 'Ürün' from Products p
inner join Categories c on p.CategoryID=c.CategoryID
inner join Suppliers s on p.SupplierID=s.SupplierID

------------------------------------------------------------------------------------------------------

--Federal shipping ile taþýnmýþ ve nancy üzerine kayýtlý olan sipariþlarin çalýþan adý ve soyadý, müþteri þirket adý, sipariþ tarihi ve kargo ücretini listeleyin.

--employees
--shippers
--orders
--customers
select (e.FirstName+' '+e.LastName) as 'Çalýþan',
c.CompanyName as 'Müþteri',
o.OrderDate as 'Sipariþ Tarihi', 
o.Freight as 'Kargo Ücret' 
from Orders o
inner join Employees e on o.EmployeeID=e.EmployeeID
inner join Customers c on o.CustomerID=c.CustomerID
inner join Shippers s on o.ShipVia=s.ShipperID
where s.CompanyName='federal shipping' and e.FirstName='nancy'

-------------------------------------------------------------------------------------------------------

--Hangi ülkelere ne kadarlýk satýþ yapýlmýþtýr? (ülkelere göre kazanýlan net ücret)

select top 3 o.ShipCountry as 'Ülke',SUM(od.UnitPrice*od.Quantity*(1-od.Discount)) as 'Toplam Gelir' from Orders o
inner join [Order Details] od on o.OrderID=od.OrderID
group by o.ShipCountry
order by 2 desc

--------------------------------------------------------------------------------------------------------

--Hangi personel hangi kategoriden toplamda kaç adet ürün satýþý yapmýþtýr.

--Çalýþan adý ve soyadý
--Kategori adý
--Toplam satýþ adet

select (e.FirstName+' '+e.LastName) as 'Çalýþan', ct.CategoryName as 'Kategori',SUM(od.Quantity) as 'Toplam Adet' from Employees e
inner join Orders o on e.EmployeeID=o.EmployeeID
inner join [Order Details] od on o.OrderID=od.OrderID
inner join Products p on od.ProductID=p.ProductID
inner join Categories ct on p.CategoryID=ct.CategoryID
group by (e.FirstName+' '+e.LastName),ct.CategoryName

-------------------------------------------------------------------------------------------------------


--hangi çalýþan hangi çalýþana baðlýdýr?

select calisan.FirstName as 'Çalýþan',mudur.FirstName as 'Müdür' from Employees calisan
inner join Employees mudur on calisan.ReportsTo=mudur.EmployeeID

--Kahveyi kazanan Irem


