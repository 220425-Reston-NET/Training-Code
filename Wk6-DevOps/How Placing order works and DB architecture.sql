Create table Customer(
	cId int identity(1,1) primary key,
	cName varchar(50)
)

create table "Order"(
	oId int identity(1,1) primary key,
	cTotal smallmoney
)

create table Product(
	pId int identity(1,1) primary key,
	pName varchar(50)
)

create table Store(
	"sId" int identity(1,1) primary key,
	sName varchar(50)
)

--Creating relationships
alter table "Order" add cId int foreign key references Customer(cId)

create table LineItem(
	oId int foreign key references "Order"(oId),
	pId int foreign key references Product(pId),
	quantity int
)

create table Inventory(
	"sId" int foreign key references Store("sId"),
	pId int foreign key references Product(pId),
	Quantity int
)

--Seed data
select * from "Order";
select * from Product;
select * from Customer;
select * from Store;
select * from Inventory;
select * from LineItem;

insert into Customer
values('Stephen'),
	('Jordan'),
	('Daniel');

insert into Product
values ('Pencil'),
	('Tablet'),
	('Mouse');

insert into Store
values ('Store1'),
	('Store2')

insert into Inventory
values (1,1,20),
	(1,2,10),
	(2,1,5),
	(2,3,10)

select s.sName, p.pName, i.Quantity from Store s
inner join Inventory i on s."sId" = i."sId"
inner join Product p on p.pId = i.pId

--You need multiple sql statements to make placing order work
--Stephen will buy 10 pencils and 5 tablets from store 1

--First step would be update the inventory
update Inventory
set Quantity = Quantity - 10
where "sId" = 1 and pId = 1

update Inventory
set Quantity = Quantity - 5
where "sId" = 1 and pId = 2


--Second step would be creating the order to start recording the history
insert into "Order"
values (10, 1)

--Third step would be adding items to the order
--Find out how to get the latest order Id that was just created to be used for this step
--If you do multiple products in the same order, you might need to put this SQL statement is a loop
insert into LineItem
values (1, 1, 10)

insert into LineItem	
values(1,2,5)

--Join statement to check that it did everything right
--Join statment to check order history
select c.cName, p.pName, o.cTotal from Customer c
inner join "Order" o on c.cId = o.cId
inner join LineItem l on l.oId = o.oId
inner join Product p on p.pId = l.pId
where c.cId = 1
