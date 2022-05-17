------------------- DDL or Data Definition Language ------------------

--Will create a new table called Pokemon
create table Pokemon (
	pokeId int,
	pokeName varchar(50),
	pokeType varchar(20),
	pokeHealth int
)

--Alter statement is changing the table itself by adding a new column
alter table Pokemon add pokeAttack int

--Alter statement to remove a column
alter table Pokemon drop column pokeAttack

--Drop statement will remove a table
drop table Pokemon

--Truncate statement - it will completely remove all data from a table
Truncate table Pokemon

---------------------- DML or Data Manipulation Language -------------------

--Insert statement
insert into Pokemon
values (2, 'Ditto', 'Neutral', 50)

insert into Pokemon
values (3, 'Charizard', 'Fire', 40),
		(4, 'Jigglypuff', 'Fairy', 80)

insert into Pokemon(pokeId, pokeName, pokeType)
values (5, 'Bulbasaur', 'Grass')

--Select statement
select pokeId, pokeName, pokeType, pokeHealth from Pokemon

--Update statement
update Pokemon set pokeHealth = 120
where pokeName = 'Pikachu'

update Pokemon set pokeHealth = 50
where pokeName = 'Ditto'

--Delete statement
delete from Pokemon
where pokeName = 'Ditto'

------------- Aggregation Function --------------------

--Summation of the entire column
select sum(pokeHealth) from Pokemon

--Count of the entire column
select count(pokeName) from Pokemon

--Minimal
select min(pokeHealth) from Pokemon

--Maximal
select max(pokeHealth) from Pokemon

--Average of the entire column
select avg(pokeHealth) from Pokemon

------------------- Constraints ------------------------

create table ConstraintsTest(
	NotNullColumn int not null,
	UniqueColumnId int unique
)

drop table ConstraintsTest

--Fails due to NotNullColumn cannot hold null value
insert into ConstraintsTest
values (null)

--Fails due to UniqueColumnId cannot hold duplicated values
insert into ConstraintsTest(UniqueColumnId, NotNullColumn)
values (1,2), (1,2)


-------------- Multiplicity ----------------

create table Person(
	personSSN int primary key,
	personName varchar(100),
	person_age int
)

create table Heart(
	heartSize int,
	healthy bit,
	personSSN int unique foreign key references Person(personSSN)
)

insert into Person
values (1, 'Stephen', 1923)

insert into Heart
values (100, 0, 1)