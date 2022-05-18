------- Creating the tables you need ----------
--1NF must have primary key and each data must be atomic
--2NF avoid having multiple columns to make up a primary key (composite primary key)
	--You must ensure that every column in a table depends on both the composite primary key
--3NF ensures every column is related/depended on the primary key 
	--Every column must depend on the primary key
create table Pokemon(--One
	pokeId int identity(1,1) primary key,
	pokeName varchar(100),
	pokeType varchar(20),
	pokeHealth int
)

create table Ability(--Many
	abId int identity(1,1) primary key,
	abName varchar(100),
	abPower int,
	abPP int --PP indicates how much left a pokemon can use that ability
)

-------------- Establishing the relationships between table -------------------

--One to One
--Just add unique and you have a one to one relationship
 alter table Ability add pokeId int unique foreign key references Pokemon(pokeId)

--One to Many If Pokemon and ability had a O to M relationship
--It is important to put the referencing column on the "Many" table
 alter table Ability add pokeId int foreign key references Pokemon(pokeId)

 --Many to Many
 create table pokemons_abilities(
	pokeId int foreign key references Pokemon(pokeId),
	abId int foreign key references Ability(abId)
 )

 ---------------- The problem with PP ---------------------------------

 --Must configure it this way because PP depends both on pokemon and ability to determine its value
 alter table pokemons_abilities add PP int

 alter table Ability drop column abPP

 ----------------- Create a sql statement first before you complete the method from C# -----------------
--Seed data into pokemon table just to check if the functionality is working
--YOU DON'T HAVE TO MAKE ADD POKEMON FUNCTION WORK JUST TO TEST GET ALL POKEMON
insert into Pokemon
values ('Pikachu', 'Electric', 20),
	('Ditto', 'Neutral', 30),
	('Charizard', 'Fire', 15)

--Used to find all data from Pokemon for GetAll method
select * from Pokemon


--Used to insert data to Pokemon Table for Add method
insert into Pokemon
values ('','',0)