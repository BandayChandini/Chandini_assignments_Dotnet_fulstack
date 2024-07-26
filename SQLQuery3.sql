Create database Assignment1
use Assignment1
create table Customers(Customerid char(5) not null,
CompanyName varchar(40) not null,
contactName char(30) null,
Address varchar(60) null,
City char(15) null,
Phone char(24) null,
Fax Char(24) null);
create table Orders(OrderId integer not null,
CustomerId char(5) not null,
Orderdate datetime null,
Shippeddate datetime null,
Freight money null,
Shipname varchar(40) null,
Shipaddress varchar(60) null,
Quantity integer null);
alter table Orders add shipregion integer null
alter table Orders alter column shipregion char(8) 
alter table Orders drop column shipregion
insert into Orders values(10,'ord01',getdate(),getdate(),100.0,'Windstar','Ocean',1)
alter table Orders add constraint Orderdate default getdate() for Orderdate
sp_rename 'Customers.City','Town','column'
