create database transactionsdemo
go

use transactionsdemo
go

create table dbo.TicketBookings(
	BookingID uniqueidentifier primary key,
	SeatNumber char(2)
)
go

create table dbo.Payments(
	PaymentID uniqueidentifier primary key,
	Amount decimal(10,2)
)
go

insert into transactionsdemo.dbo.TicketBookings values(newid(), 'A1')
insert into transactionsdemo.dbo.TicketBookings values(newid(), 'C4')
go

insert into transactionsdemo.dbo.Payments values(newid(), 150)
insert into transactionsdemo.dbo.Payments values(newid(), 150)
go
