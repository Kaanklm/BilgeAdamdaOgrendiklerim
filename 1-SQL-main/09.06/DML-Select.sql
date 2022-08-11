--DML (Veri tan�mlama dili)
	--select
	--update
	--insert
	--delete
--DDL (Veri i�leme dili)
	--create
	--drop
	--alter
--DCL (Veri Kontrol dili)
	--grant
	--deny
	--revoke

-------------------------------------------------------------------------

use Northwind -- use anahtar kelimesi hangi veritaban� �zerinde �al��aca��n� temsil eder.

select * from Products

--Ctrl+r tu� kombinasyonu ile result penceresini gizleyebilirsiniz.

--�al��anlar tablosundan �al��anlara ait ad, soyad, g�rev, do�um tarihi bilgilerini T�rk�e kolon isimleriyle listeleyin.

select FirstName as 'Ad', LastName as 'Soyad', BirthDate as 'Do�um Tarihi', Title as 'G�rev'   from Employees

select FirstName Ad, LastName Soyad, BirthDate Do�umTarihi, Title G�rev from Employees

-------------------------------------------------------------------------

--�al��anlar�n �ehirlerini listeleyin. (Kolon ismi T�rk�e olacak.)

select city as '�ehir' from Employees

--�ehirleri listeleyin (tekrar edilmesin.)

select distinct City from Employees

--distinct tekrar eden verileri getirmez.

---------------------------------------------

select (FirstName+' '+LastName) as 'Ad Soyad' from Employees


--not: + ifadesini metinsel de�erde kullan�rsan�z "birle�tirme" say�sal ifadede kullan�rsan�z "toplama" i�lemini ger�ekle�tirir.

----------------------------------------------

--�r�nleri �r�n ad�, fiyat� ve stok miktar� ile listeleyin.

select ProductName as '�r�n Ad�', UnitPrice as 'Fiyat', UnitsInStock as 'Stok Miktar�' from Products





