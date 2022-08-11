--Where: filitreleme (Kriter) i�lemi yapar. 


--�r�n id'si 1 olan� listeyin.
select * from Products where ProductID=1

--Operat�rler

/*
	> b�y�kt�r
	< k���kt�r
	>= b�y�k e�ittir.
	<= k���k e�ittir.
	<> e�it de�ildir.
	!= e�it de�ildir.

*/

--�r�n fiyat� 30'dan b�y�k olanlar� listeleyin.

select * from Products where UnitPrice>30

-- Fiyat� 10 ile 40 aras�nda olan �r�nleri listeleyin.

--I.Yol
select * from Products where UnitPrice>10 and UnitPrice<40

--II.Yol
select * from Products where UnitPrice between 10 and 40

--------------------------------------------------------------

--in ifadesi 10 ya da 40 olan �r�nleri getirir.
select * from Products where UnitPrice in(10,40)

--------------------------------------------------------------

--stok miktar� 10'dan k���k olan �r�nlerin �r�n ad�, fiyat�, ve stok miktar�n� listeleyin.

select ProductName as '�r�n Ad�', UnitPrice as 'Fiyat', UnitsInStock as 'Stok Miktar�' from Products where UnitsInStock<10

---------------------------------------------------------------

--�al��anlardan ad� janet olan'�n bilgilerini listeleyin.
select * from Employees where FirstName='janet'





