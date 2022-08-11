--DDL (Data definition language)
 --Create
 --Alter
 --Drop

 --CREATE
 create database InstagramDB
 go
 use InstagramDB
 go
 create table Users
 (
	ID int not null primary key identity(1,1),
	UserName nvarchar(50) not null,
	Password nvarchar(50) not null,
	Email nvarchar(250) not null
 )
 go
 insert into Users values ('fatih','1234','fatih.gunalp@bilgeadam.com'),('irem','1234','irem@gmail.com')
 go
 create table UserProfiles
 (
	ID int not null primary key foreign key references Users(ID),
	FirstName nvarchar(50),
	LastName nvarchar(50),
	BirthDate date,
	Gender bit
 )
 go
 insert into UserProfiles values (1,'fatih','g�nalp','07.05.1985',1),(2,'irem','p�nar','05.04.1990',0)
 go
 create table Photos(
	ID int not null primary key identity(1,1),
	UserId int not null foreign key references Users(ID),
	PublishedDate datetime,
	PhotoPath nvarchar(250),
	Description nvarchar(500)
 )

 --Foto�raflara �rnek bir veri eklenecek.
 insert into Photos values (1,'06.15.2021','C:\users\desktop\manzara.png','ya�murlu bir g�n')
 go
 --Foto�raf Yorumlar� isimli tablo olu�turulacak.
 create table PhotoComments(
	ID int not null primary key identity(1,1),
	PhotoId int not null foreign key references Photos(ID),
	UserId int not null foreign key references Users(ID),
	PublishedDate datetime,
	Description nvarchar(500)
 )
 --foto�raf yorumlar� tablosuna �rnek veri eklenecek.
 insert into PhotoComments values (1,2,'06.15.2021','g�zel bir manzara')
 --Mesajlar isimli tablo olu�turulacak
 create table Messages(
	ID int not null primary key identity(1,1),
	SenderId int not null foreign key references Users(ID),
	ReceiverId int not null foreign key references Users(ID),
	MessageBody nvarchar(max) not null,
	CreatedDate datetime
 )
 --Mesajlar isimli tabloya �rnek 2 adet veri eklenecek
 insert into Messages values (2,1,'nerde �ektin bu foto�raf�?','06.15.2021'),(1,2,'Kad�k�yde �ektim','06.15.2021')

 ----------------------------------------------------------

 select * from Users
 select * from UserProfiles

 select * from Photos
 select * from PhotoComments
 ----------------------------------------------------------

 alter table UserProfiles
 add ProfilePicture  nvarchar(250)
 --------------------------------------------------------
 alter table UserProfiles
 alter column ProfilePicture nchar(250)

 --------------------------------------------------------
 create table TestTable
 (
	ID int not null primary key identity(1,1),
	Description nvarchar(500)
 )
 ----------------------------------------------------------
 drop table TestTable
 ------------------------------------------------------
 drop database InstagramDB

 use master
 drop database InstagramDB
 ------------------------------------

 ---Finished!