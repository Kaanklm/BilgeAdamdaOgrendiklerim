--Like Komutu

--�r�n ad�n�n herhangi bir yerinde i harfi ge�en �r�nleri listeleyin.
select * from Products where ProductName like '%i'

--% i�areti hepsini temsil eder e�er 2 adet % i�areti ve aras�nda kelime/karakter varsa �ncesi ve sonras� �nemli de�il i�inde belirtilen kelime/karakter ge�enleri getirir.

--3. karakteri a olan �r�nleri listeleyin.

select * from Products where ProductName like '__a%'

--3. karakteri a olmayan �r�nleri listeleyin.

--I. YOL
select * from Products where ProductName not like '__a%'

--II.YOL
select * from Products where ProductName like '__[^a]%'

------------------------------------------------------------------

--3.karakteri a olmayan ve 2. karakteri c olan �r�nleri listeleyin.
--I.YOL
select * from Products Where ProductName not like '__a%' and ProductName like '_c%'
--II.Yol
select * from Products Where ProductName like '_c[^a]%'

-----------------------------------------------

--Sipari�ler tablosunda sipari�in ta��nma zaman� girilmemi� kay�tlar� listeleyin.

select * from Orders where ShippedDate is null


--Japonca bilen personelim kimdir?
--Yasin
--Burcu
--ahmet sait
--ahmet �avu�

select * from Employees where Notes like '%japanese%'




