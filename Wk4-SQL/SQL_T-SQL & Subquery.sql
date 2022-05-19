--One
create table Roles(
	roleId int identity(1,1) primary key,
	roleTitle varchar(50),
	roleSalary smallmoney
);


--Many
create table Employee(
	empId int identity(1,1) primary key,
	empName varchar(50),
	roleId int foreign key references Roles(roleId)
);

INSERT INTO Roles
	VALUES ('CEO', 100000),
			('Scientist', 80000),
			('Fry Cook', 50000),
			('Cashier', 27000),
			('Interns', 10000);
			
INSERT INTO Employee
	VALUES ('Eugene Krabs', 1),
			('Spongebob Squarepant', 3),
			('Sandy Cheeks', 2),
			('Squidward Tentacles', 4),
			('Sheldon Plankton', 2);

------------- Set Operations ---------------------
insert into Employee
values ('Cashier', 4)

--Union
select roleTitle from Roles
union
select empName from Employee

--Union all
select roleTitle from Roles
union all
select empName from Employee

--Except
select roleTitle from Roles
except
select empName from Employee

--Intersect
select roleTitle from Roles
Intersect
select empName from Employee

-------------------- Stored Procedures ------------------

--It will add employee and/or role in the table
alter procedure proc_addData(
	@which varchar(20),
	@name varchar(50) = null, --Optional parameter is made by setting it a default value
	@roleId int = null,
	@roleTitle varchar(50) = null,
	@roleSalary smallmoney = null,
	@status bit output --output keyword changes the parameter into an output parameter
)
as
begin
	if(@which = 'employee')
	begin
		insert into Employee
		values(@name, @roleId);

		set @status = 1;
	end
	if(@which = 'role')
	begin
		insert into Roles
		values(@roleTitle, @roleSalary);

		set @status = 1;
	end
	else
	begin
		set @status = 0;
	end
end;

--Must use exec keyword to execute a stored procedure
declare @currentStatus bit
exec proc_addData @which = 'kjahsfe', @roleTitle = 'Karate', @roleSalary = 10, @status = @currentStatus output;
select @currentStatus

----------- Triggers ---------------

--Will add 10000 from everyone's salary whenever someone quits
alter trigger employee_removed on Employee
after delete
as
begin
	update Roles set roleSalary = roleSalary + 10000;
end

create trigger employee_removed on Employee
before 

select * from Roles

delete from Employee
where empName = 'Spongebob Squarepants'

--------------- Subquery ---------------------

--I want to find the salaries from Roles that are higher than the average
select avg(roleSalary) from Roles

select roleSalary from Roles
where roleSalary > avg(roleSalary)

--You can do subquery
--When you have a query within a query to bypass certain annoying rules such as where clause not being compatible with an aggregate function
select roleSalary from Roles
where roleSalary > (
	select avg(roleSalary) from Roles
)

select * from (
	select * from Roles where roleSalary > 20000
) as Role
where roleSalary > 50000