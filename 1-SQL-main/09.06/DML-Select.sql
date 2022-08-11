--DML (Veri tanýmlama dili)
	--select
	--update
	--insert
	--delete
--DDL (Veri iþleme dili)
	--create
	--drop
	--alter
--DCL (Veri Kontrol dili)
	--grant
	--deny
	--revoke

-------------------------------------------------------------------------

use Northwind -- use anahtar kelimesi hangi veritabaný üzerinde çalýþacaðýný temsil eder.

select * from Products

--Ctrl+r tuþ kombinasyonu ile result penceresini gizleyebilirsiniz.

--Çalýþanlar tablosundan çalýþanlara ait ad, soyad, görev, doðum tarihi bilgilerini Türkçe kolon isimleriyle listeleyin.

select FirstName as 'Ad', LastName as 'Soyad', BirthDate as 'Doðum Tarihi', Title as 'Görev'   from Employees

select FirstName Ad, LastName Soyad, BirthDate DoðumTarihi, Title Görev from Employees

-------------------------------------------------------------------------

--Çalýþanlarýn þehirlerini listeleyin. (Kolon ismi Türkçe olacak.)

select city as 'Þehir' from Employees

--þehirleri listeleyin (tekrar edilmesin.)

select distinct City from Employees

--distinct tekrar eden verileri getirmez.

---------------------------------------------

select (FirstName+' '+LastName) as 'Ad Soyad' from Employees


--not: + ifadesini metinsel deðerde kullanýrsanýz "birleþtirme" sayýsal ifadede kullanýrsanýz "toplama" iþlemini gerçekleþtirir.

----------------------------------------------

--Ürünleri ürün adý, fiyatý ve stok miktarý ile listeleyin.

select ProductName as 'Ürün Adý', UnitPrice as 'Fiyat', UnitsInStock as 'Stok Miktarý' from Products





