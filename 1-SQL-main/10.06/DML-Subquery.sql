--SubQuery

--Fiyatý ortalama fiyatýn altýnda olan ürünleri listeleyin.

select AVG(UnitPrice) from Products

select * from Products where UnitPrice<28.86

------------------------------------------------------------

select * from Products where UnitPrice<(select AVG(UnitPrice) from Products)

--------------------------------------------------------------

--ürünler tablosunu tedarikçi adý, kategori adý, ürün adý, fiyat ve stok bilgileri ile listeleyin.

select 
(select CompanyName from Suppliers where Suppliers.SupplierID=Products.SupplierID ),
(select CategoryName from Categories where Categories.CategoryID=Products.CategoryID),
ProductName,UnitPrice,UnitsInStock from Products

--Önemli=> alt sorgudan her zaman tek bir sonuç döndürülmelidir!
-----------------------------------------------------------------

--satýþlar tablosunu müþteri adý, personel adý ve soyadý ile birlikte listeleyin.


select 
(select ContactName from Customers where Customers.CustomerID=Orders.CustomerID) as 'Müþteri',
(select (FirstName+' '+LastName) from Employees where Employees.EmployeeID=Orders.EmployeeID) as 'Çalýþan', OrderID from Orders

------------------------------------------------------------------

--ürün adý ile birlikte o ürünün toplam satýþ adet bilgisini listeleyin.
select p.ProductName,(select SUM(od.Quantity) from [Order Details] od where od.ProductID=p.ProductID )  from Products p

----------------------------------------------------------

--Adý janet olan personelin yapmýþ olduðu satýþlarý listeleyin.

select * from Orders where EmployeeID=(select EmployeeID from Employees where FirstName='janet')

--Personel adý steven olan ve nakliyecisi "federal shipping" olan satýþlarý listeleyin.

select * from Orders where EmployeeID=(select EmployeeID from Employees where FirstName='steven') 
and 
ShipVia=(select ShipperID from Shippers where CompanyName='federal shipping')


