/*
	Having

	Soprgu sonucu gelen sonuç kümesi üzerinde Aggregate fonksiyonlara baðlý olacak þekilde bir filitreleme iþlemi yapýlacaksa where komutu yerine having komutu kullanýlýr. Bu sayede Aggregate fonksiyonlarý da filitreleme iþlemlerine dahil etmiþ oluruz.
*/


--Her bir sipariþteki toplam ürün sayýsý 100'den az olanlarý listeleyin.

select * from [Order Details] where SUM(Quantity)<100 -- bu sorgu bize hata verecektir. Çünkü where komutundan sonra aggregate(sum()) kullanýlamaz. onun yerine aþaðýdaki örneði inceleyebiliriz.

select OrderID,SUM(Quantity) from [Order Details] group by OrderID having SUM(Quantity)<100--bu örnekte yine select ile from arasýnda listenelecek olan kolonlarý belirterek aggregate haricinde kalan kolonu (OrderId) group by içerisine alýyoruz. Yani ilk etapta gruplama iþlemi gerçekleþtiriyoruz. Ardýndan bize teslim edilen sonuç kümesi üzerinde bir filitreleme uygulamak için having komutunu kullanarak sonuca baðlý olacak þekilde bir kriter uygulamýþ oluyoruz.

--Stokta hangi kategoriden toplam ne kadarlýk ürün vardýr? 10000'den çok olanlarý listeleyin.
select CategoryID, SUM(UnitsInStock*UnitPrice) from Products 
group by CategoryID 
having SUM(UnitsInStock*UnitPrice) >10000

--Hangi personel hangi müþteriye kaç adet satýþ yapmýþtýr? 2 satýþtan büyük olanlarý listeleyin.

select EmployeeID,CustomerID,COUNT(*) from Orders group by EmployeeID,CustomerID having COUNT(*)>2

--------------------------------------------------------------------------------------------------
