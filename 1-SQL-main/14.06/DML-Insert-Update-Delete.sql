
--DML
	--select
	--insert => veri ekleme
	--update => güncelleme
	--delete => silme
--DDL
	--Create
	--Alter
	--Drop
--DCL
	--Grant
	--Deny
	--Revoke
-------------------------------------------------------

select * from Products order by ProductID desc

--INSERT
/*
	ProductName: Kai
	supllierId:2
	categoryId:2
	UnitPrice:100
	UnitsInStock:20
*/

--I.YOL
insert into Products (ProductName,SupplierID,CategoryID,UnitPrice,UnitsInStock) values ('Kai',2,2,100,20)

--II.YOL

insert Products values ('Kau',2,1,null,50,20,0,0,0)

-------------------------------------------------------------------------------------------------------

--UPDATE

update Products set ProductName='Kaju' where ProductID=78

select * from Products

-----------------------------------------------------------

--DELETE
delete from Products where ProductID=78
----------------------------------------------------------------------------------

