--Çalışanların yaşlarının toplamını bulunuz.

select SUM(YEAR(GETDATE())-YEAR(BirthDate)) from Employees

--SUM() => toplama fonksiyonu
--Year() => yıl fonksiyonu. (parametre olarak tanımlanan tarihin yılını verir.)
--GetDate() => şuanki tarihi verir.

