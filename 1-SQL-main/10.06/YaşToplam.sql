--�al��anlar�n ya�lar�n�n toplam�n� bulunuz.

select SUM(YEAR(GETDATE())-YEAR(BirthDate)) from Employees

--SUM() => toplama fonksiyonu
--Year() => y�l fonksiyonu. (parametre olarak tan�mlanan tarihin y�l�n� verir.)
--GetDate() => �uanki tarihi verir.

