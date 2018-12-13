

create table Spare
(
	Id int identity primary key,
	NameSpare nvarchar(255) not null,
	Article int not null,
	Price decimal(19,4) not null,
	[Description] nvarchar(255) not null,
	DateAdded datetime,
	IsDelete bit default 0,
	Photo varbinary(max),
	TypeSpareId int not null,
	Foreign key (TypeSpareId) references TypeSpare(Id)
)

create table TypeSpare
(
	Id int identity primary key,
	TypeName nvarchar(255)
)

create table Corb
(
	Id int identity primary key,
	SpareId int not null,
	BuyerId nvarchar(450) not null, 
	DateOfCreate datetime,
	IsActive bit default 1,
	DateOfSale datetime,
	Foreign key (SpareId) references AspNetUsers (Id),
)

select * from TypeSpare

drop table TypeSpare



