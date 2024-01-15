create database Assignment1
 use Assignment1
 create table Customers(
 Customerid char(5) not null,
 CompanyName varchar(40) not null, contactName char(30) null, [Address] varchar(60) null,
City char(15) null,
Phone char(24) null,
Fax char(24) null)--Order Tablecreate table Orders(OrderId integer not null,
customerId char(5) not null,
Orderdate datetime null,
Shippeddate datetime null,
Freight money null,
Shipname varchar(40) null,
Shipaddres varchar(60) null,
Quantity integer null)--2 questionAlter table Orders Add shipregion integer null--Question 3Alter table Orders Alter column shipregion char(8) null--Question 4alter table Orders drop column shipregion--Question 5insert into Orders values( 10, 'ord01', getdate(), getdate(), 100.0, 'Windstar', 'Ocean',1)select*from Orders--Question 6alter table Orders Add CONSTRAINT date_df default getdate() for Orderdate--Question 7sp_rename 'Customers.city','Town'