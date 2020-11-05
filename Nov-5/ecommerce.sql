create database eCommerce
go

use eCommerce
go

--Table that represents a set of administrators
create table dbo.Administrators
(
	AdminID uniqueidentifier primary key,
	AdminName varchar(30) not null,
	Username varchar(30) not null,
	Password varchar(30) not null,
	DateOfCreation datetime,
	DateOfModification datetime
)
go

--Table that represents a set of customers with details such as name, email etc.
create table dbo.Customers
(
	CustomerID uniqueidentifier primary key,
	CustomerName varchar(30) not null,
	Email varchar(40),
	Username varchar(30) not null,
	Password varchar(30) not null,
	DateOfRegistration datetime,
	DateOfModification datetime
)
go

--Table that represents a set of products such as product name, unit price, stock quantity etc.
create table dbo.Products
(
	ProductID int identity(1,1) primary key,
	ProductName varchar(30) not null,
	UnitPrice decimal(16,2),
	QuantityInStock int default(0),
	DateOfCreation datetime,
	DateOfModification datetime
)
go


insert into dbo.Administrators values(newid(), 'Administrator', 'admin', '123', getdate(), getdate())
go

insert into dbo.Products values(newid(), 'Dell Laptop', 30000, 50, getdate(), getdate())
insert into dbo.Products values(newid(), 'HP Mouse', 250, 81, getdate(), getdate())
go