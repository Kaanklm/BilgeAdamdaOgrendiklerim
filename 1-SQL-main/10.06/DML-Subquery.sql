--SubQuery

--Fiyat� ortalama fiyat�n alt�nda olan �r�nleri listeleyin.

select AVG(UnitPrice) from Products

select * from Products where UnitPrice<28.86

------------------------------------------------------------

select * from Products where UnitPrice<(select AVG(UnitPrice) from Products)

--------------------------------------------------------------

--�r�nler tablosunu tedarik�i ad�, kategori ad�, �r�n ad�, fiyat ve stok bilgileri ile listeleyin.

select 
(select CompanyName from Suppliers where Suppliers.SupplierID=Products.SupplierID ),
(select CategoryName from Categories where Categories.CategoryID=Products.CategoryID),
ProductName,UnitPrice,UnitsInStock from Products

--�nemli=> alt sorgudan her zaman tek bir sonu� d�nd�r�lmelidir!
-----------------------------------------------------------------

--sat��lar tablosunu m��teri ad�, personel ad� ve soyad� ile birlikte listeleyin.


select 
(select ContactName from Customers where Customers.CustomerID=Orders.CustomerID) as 'M��teri',
(select (FirstName+' '+LastName) from Employees where Employees.EmployeeID=Orders.EmployeeID) as '�al��an', OrderID from Orders

------------------------------------------------------------------

--�r�n ad� ile birlikte o �r�n�n toplam sat�� adet bilgisini listeleyin.
select p.ProductName,(select SUM(od.Quantity) from [Order Details] od where od.ProductID=p.ProductID )  from Products p

----------------------------------------------------------

--Ad� janet olan personelin yapm�� oldu�u sat��lar� listeleyin.

select * from Orders where EmployeeID=(select EmployeeID from Employees where FirstName='janet')

--Personel ad� steven olan ve nakliyecisi "federal shipping" olan sat��lar� listeleyin.

select * from Orders where EmployeeID=(select EmployeeID from Employees where FirstName='steven') 
and 
ShipVia=(select ShipperID from Shippers where CompanyName='federal shipping')


