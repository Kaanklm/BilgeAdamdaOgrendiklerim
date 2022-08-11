/*
	Having

	Soprgu sonucu gelen sonu� k�mesi �zerinde Aggregate fonksiyonlara ba�l� olacak �ekilde bir filitreleme i�lemi yap�lacaksa where komutu yerine having komutu kullan�l�r. Bu sayede Aggregate fonksiyonlar� da filitreleme i�lemlerine dahil etmi� oluruz.
*/


--Her bir sipari�teki toplam �r�n say�s� 100'den az olanlar� listeleyin.

select * from [Order Details] where SUM(Quantity)<100 -- bu sorgu bize hata verecektir. ��nk� where komutundan sonra aggregate(sum()) kullan�lamaz. onun yerine a�a��daki �rne�i inceleyebiliriz.

select OrderID,SUM(Quantity) from [Order Details] group by OrderID having SUM(Quantity)<100--bu �rnekte yine select ile from aras�nda listenelecek olan kolonlar� belirterek aggregate haricinde kalan kolonu (OrderId) group by i�erisine al�yoruz. Yani ilk etapta gruplama i�lemi ger�ekle�tiriyoruz. Ard�ndan bize teslim edilen sonu� k�mesi �zerinde bir filitreleme uygulamak i�in having komutunu kullanarak sonuca ba�l� olacak �ekilde bir kriter uygulam�� oluyoruz.

--Stokta hangi kategoriden toplam ne kadarl�k �r�n vard�r? 10000'den �ok olanlar� listeleyin.
select CategoryID, SUM(UnitsInStock*UnitPrice) from Products 
group by CategoryID 
having SUM(UnitsInStock*UnitPrice) >10000

--Hangi personel hangi m��teriye ka� adet sat�� yapm��t�r? 2 sat��tan b�y�k olanlar� listeleyin.

select EmployeeID,CustomerID,COUNT(*) from Orders group by EmployeeID,CustomerID having COUNT(*)>2

--------------------------------------------------------------------------------------------------
