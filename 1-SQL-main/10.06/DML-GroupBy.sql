--Group by

/*
	Group by komutu tablodaki ortak verilerin gruplanarak d�nmesini sa�lar. Group by kullan�m�ndan �nce gruplanacak olan alanlar belirlenip daha sonra o alanlara g�re bir select sorgusu ger�ekle�tirilir.
*/

--hangi kategoriden ka� adet �r�n vard�r?

select CategoryId, COUNT(CategoryID) as 'Adet' from Products group by CategoryID

--Not: Aggregate function haricinde kalan b�t�n kolonlar group by i�erisinde kullan�l�r.

--�lkelere g�re �al��an say�s�n� listeleyin.
select Country,COUNT(Country) as 'Ki�i Say�s�' from Employees group by Country

--Stokta hangi kategoriden toplam ne kadarl�k �r�n vard�r?
select CategoryID,SUM(UnitPrice*UnitsInStock) from Products group by CategoryID

--Order by
select CategoryID,SUM(UnitPrice*UnitsInStock) as 'Toplam' from Products group by CategoryID order by Toplam desc
