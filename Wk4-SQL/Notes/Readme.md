# Introduction to SQL
* Structured Query Language
* Just a language made to be really good at storing and querying (grabbing data) information from a database
* Now it isn't really a programming langauge (I know confusing) since it lacks basic tools that a normal programming language has
    * Control flow statements? HA non-existent
    * To re-cap, control flow statements are the for loops and if statements
* It is just a query langauge because it is a language made to get data
* However, down the line, people didn't like this so they created multiple versions of SQL that acts like a proper programming language 
    * Ex: Pl/pgSQL, T-SQL, PL-SQL, etc. (<- you don't need to know the different type of SQL except for T-SQL)
## Database
* It is just an organized collection of data stored in some format
* They allow us to input, manage, organize, and retrieve data quickly
* With most databases, they are organized into tables and each table will have a row and a column
    * Think of a Microsoft Excel sheet
    * Data is the actual intersection between a row and column 
## Rational Database Management System (RDBMS)
* A more advance form of a database with an even fancier name.
* So instead of just storing data like a database, it gives "relationships" between data
    * Look at Multiplicity section to showcase "relationship" between data

## SQL Sublanguages
* Essentially, people decided to organized what each statement (They decided to call it statements instead of functions so... start thinking they are the same thing) does in our RDBMS
## Data Definition Langauge (DDL)
* It is used for the creation/alteration of tables, 
* CREATE - most commonly used to create tables
* ALTER - used to alter/modify existing tables
* TRUNCATE - removes all data in a table, **cannot rollback the changes**
* DROP - removes the table structure from the database
## Data Manipulation Langauge (DML)
* It is for changing/manipulating/modifying the data within a table
* INSERT - Adds data(rows) to your table
* SELECT - Retrieves the data from a table for us to read
* UPDATE - Modify/updates the data from a table
    - You can use the where clause to select/filter the data in a table
* DELETE - Deletes a row from a table
    - You can use the where clause to select/filter which data to remove

# Constraints
* They are a way for us to limit the data that will come into your table (hence the name "constraints")
* It will specify either one or more rules that the data you are inputting in that column must follow
## some commonly used constraints
1. Type - Restricts what datatype you can store in a column
2. Unique - Every data in a column cannot have repeating values
3. Not null - Ensures every data in a column must have a value
4. Check - Adds an extra condition on the data
    * Ex: age column must be above 18
```SQL
CREATE TABLE Person (
    Age int CHECK (Age >= 18)
)
```
5. Primary Key
    * Implicitly Unique and Not null
    * Acts as the unique identifier for the rows in a table
6. Foreign Key
    * Data in this column references the primary key of another table
    * Establishes relationships between 2 columns in the same table or different tables

# Multiplicity
* It is a way to describe the relationships between 2 tables
* We will use the primary and foreign keys to established these relationships
## Three main categories of relationships
* One to One
    * When one row in Table A is directly related to one row in Table B and vice versa
    * You must use the unique constraint in the foreign key to ensure that only one row in Table B will be related to one row in Table A
    * Ex: One person can only have one heart
* One to Many
    * When one row in Table A is related to multiple rows in Table B
    * Ex: One person has many fingers but only one finger is related to one person (you cannot share fingers!)
* Many to Many
    * Many rows in Table A is related to many rows in Table B
    * You must construct a join table to achieve many to many relationship
        * Join tables must at least consists of two columns that are both foreign keys that either points to Table A and Table B
        * Essentially, one column references Table A and one column references Table B
    * Ex: A pokemon can have many abilities and An ability can have many pokemon
        * Basically Tackle can exist to many pokemons and can share it and pokemon can have many abilities beyond just tackle

# Normalization
* It is a design pattern that reduces/eliminates data redundancy
* Ensures that every data we put in our database won't be repeating to save valuable memory space
* Must always ensure Referential Integrity Atomic data
    * Referential Integerity - a foreign key will always point to a primary key **(it is entirely possible for a foreign key column to also point to a null value but that isn't good practice)**
    * Atomic data - every data you store must be at its smallest form
## 0NF - Zero Normal Form
* No normalization is applied
## 1NF - First Normal Form
* Every table must have a primary key
* The Fancy way of saying is that every table structure must have an identifiable row
* All data must be atomic
## 2NF - Second Normal Form
* Table needs to be in 1NF
* Removes any partial dependencies
    * Easier way of thinking about it is just avoid composite primary keys and by default, you are in 2NF
    * Fancy way is that every column defined in a table must be dependent on both composite primary keys
## 3NF - Third Normal Form
* Table needs to be in 2NF
* Remove transitive dependencies
    * Ensure that every column in a table is related to the primary key
    * Ex: customerId should have columns that is related to customer, adding managerName or storeName as a column will break 3NF
    * Just put it on a different table instead if you see unrelated data together so it should be Customer Table, Manager Table, and Store Table

# Joins
* Allows us to bring together data from multiple tables
* Mostly used for tables that have existing relationships
    * But it is entirely possible to join two tables that doesn't have a primary or foreign key
## Inner join
* Return rows with matching values
## Left join
* Returns all rows from the left table and returns only matching values from the right table
## Right join
* Returns only matching values from the left table and returns all rows from the right table
## Full join
* Returns all rows from both tables but still matches rows that match

# Subquery
* When one sql statement is not enough
* It allows you to add a query statement upon a query statement and so on and on...
* Can be put next to a from and where clause
    * from clause if you want to select from a filtered table
    * where clause if you want to select some data and use it as a way to filter your data
* Subqueries are inside of '()' syntax

# Common Table Expression (CTE)
* Creating a temporary table in SQL to do some operations on
* Almost the same as a subquery but it generates a temporary table
* Seems very useless to us (because it is at the moment) but more complex databases that have 30-50 tables can make temporary tables extremely useful to save work and rewriting the same join statement 50 times

# Set Operations
* Special type of join
* It doesn't need to specify what the two tables needs to match on
* It will combine two queries together
    * They need to have the same # of columns and same datatype

## Union
* It will show every value from both queries only once
* Any duplicated values will only display once

## Union All
* It will display every value from both queries including duplicated values

## Except
* It will show only unique values from the right query
* It will not show any duplicated values

## Intersect
* It will show only duplicated values once from both queries

# Procedures
* Almost the same as the methods in C# but has certain unique characteristics
* Like a method, it can accept input parameters but it can also output multiple parameters
* Essentially, it can return **multiple datatypes**
* You can also have optional parameters
* Like a method, it is reusable

# Triggers
* They are a special type of procedure that will run when a certain event happens such as insert, update, or delete
* You can specify when you want the trigger to happen such as:
    * After/For - execute trigger after the event
    * Instead of - executes the trigger's operation instead of the event

# ACID
* A set of properties of database transaction that is intended to guarantee validity even in the event of catostrophic error or system failures
* Basically, you ensure that your database won't be corrupted if something bad happens

## Transaction
* Think of a method in C# meaning it can run multiple query statements in a single transaction
* They will help prevent data inconsistency because they will either execute all sql statement inside the transaction or not
* Essentially, they will rollback (put everything back the way it was) all the change they did if something bad happens

## Atomicity
* Either all query statements should execute or none of them will
* Meaning all sql statements inside some function/stored procedure/trigger (or just use transaction) should execute all its sql statement or none of them

## Consistency
* There should be a transparent consistency in your database
* Data should be consistent before and after a transaction
* Ex: transferring funds from checking to savings should equal to the total value of funds in both accounts
    * $100 (checking) - $10 (transfer) = $90 (checking) and $10 (savings)
    * $90 (checking) + $10(savings) = $100

## Isolation
* The state of a transaction should be invisible to other transaction
* Can't access the result of other transaction until the transaction completes
### Degrees of isolation
* Read uncommitted - does not protect the transaction from any bad phenomenon
* Read committed (default) - Prevents data from being read by a transaction that is updating it until it finishes committing
    * Prevents Dirty read
* Repeatable read - forces the second transaction to wait for the first transaction to update the data
    * Prevents dirty read and non-repeatable read
* Serializable - Forces the second transaction to wait for insert, delete, update, etc. to be finished from the first transaction
    * Highest degree of isolation and prevents all phenomenons
    * Essentially stops all concurrent transactions from happening
### Different bad phenomenon that occurs during concurrent transaction
* Dirty read - reading data that has not been committed
    * If transaction 1 updated a row followed by transaction 2 reading that updated row and all sudden something went wrong with transaction 1 it will roll back the changes and now transaction 2 had read data that basically never existed
* Non-repeatable read - when data was read twice but comes out different on each time
    * If transaction 1 read a row (it has a value of 5) and transaction 2 updates that row (to be 10) and transaction 1 reads that same row (it has a value of 10) and it came out different than the first read. 
* Phantom read - when data was added or removed by another transaction
    * If transaction 1 finds the average of a column and transaction 2 comes in and add a new number to that column and transaction 1 finds the average of the column again and it'll changed because of that new row that was added 

## Durability
* Once a transation is completed, the changes that it made is permanent in the database
* If there is a system failure, all data is safegaurded (meaning it is still there after the failure)

# ADO.NET
* Another library (that already exists in our .NET 6 framework) that specializes in connecting to different types of databases/data sources to do CRUD operations on
    * CRUD - create/read/update/delete data on the database
* It provides helpful classes that handles the connection, execution, and reading of the data from a database
* We used System.Data.SqlClient external package to specify we are specifically connecting to a SQL Server database
    * This package will change if you change the engine of your database

## SqlConnection (Can also be named as just Connection)
* A class that is used to establish a connection to a Sql Server database
* You can think of the SqlConnection object as a representation of an existing connection to a database
* The very first step required to start messing with a database

## SqlCommand (Can also be named as just Command)
* A class that is used to execute SQL statements to a SQL Server database
* You can think of the SqlCommand object as a representation of the query statement you want to execute

## SqlDataReader (Can also be name as just DataReader)
* A class that is used to read what is exactly given to you when you execute a SQL statement
* Since C# only understands classes and objects while SQL only understands tables, this class is the middle man that will provide the conversion tools required to convert SQL datatypes to C# datatypes
* You still have to map things manually but at least you can grab the data and convert it into datatypes that C# understands

## SqlDataAdapter
* A class that we don't need to use but it is the actual class that stores information in a DataSet after grabbing information from a database
* Not only that, it can also perform some query statements to also update the database (It is like a 2 in 1 a combination between SqlDataReader and SqlCommand)
* Difference is it stores the info in a Dataset and follows the disconnect architecture type
* Essentially it is the translator that converts SQL table into C# object (which is the DataSet)
    * With added benefit of also performing some database operations as well
### DataSet
* This is the actual model that SqlDataAdapter uses to store a "table" in C#
* You can think of it as a representation of a in-memory table in SQL but in C#

# Architecture of ADO.NET
* Ha! I scared you there for a second, no we don't need to know another architecture and how they structured and make ADO.net work
* Instead, we just need to know the two types of architecture and what's their difference
## Connected Architecture
* Your application has a constant connection to a database
    * At its core that is really all this means
* As a programmer, that means utilizing SqlConnection, SqlCommand, and (optional) SqlDataReader class so we are doing connected architecture
    * Remember .Open() method? Yeah that initiates a constant connection to the database
## Disconnected Architecture
* Your application only establishes a connection if it needs something with the database
* As a programmer, you need to utilize SqlDataAdapter class instead 
    * It still needs SqlConnection class to dictate what database you are trying to do operations on
        * However, you don't need to use .Open() method
    * Feel free to look up what that code looks like but we don't need to apply it

# Moar Design Patterns
* Because we have 99 problems with coding but design patterns won't be one
## Repository Design Pattern
* When your application has a layer between your actual application and your database using interface or abstraction for accessing the database directly
    * We already implemented it and it is our Data Layer project
* Essentially, we have a middle man between your app and the database that has a sole responsiblity of anything data accessing to the database
* Since we use abstraction, nothing will "break" when updating just your data layer and you can use as many C# files that can tap to multiple data source, tables, etc.
## Unit of Work Design Pattern
* For the most part, your repository should only have simple CRUD operations that messes with the database
* Any "complex" operations that require more than one CRUD operations from the repository should be handled in the Unit of Work layer (our BL)
* This is another layer that is before your application and it's sole responsiblility is to act like a **transaction**
    * Meaning it either executes all of the query statements or none at all
* A design pattern that follows the Atomicity property to prevent **Data inconsistency**

# Things I didn't go over but QC might ask
* Main reason I didn't go over it because using it can lead to so many data inconsistency if used improperly
## Cascading delete
* You know how deleting information from a table can lead to an error if that data is being referenced by another table
* Well adding cascading delete will essentially ignore that safety net and delete it anyway and any data that referenced to it will be replaced with a NULL value instead
* Rarely used because it can lead to massive amount of **data inconsistency**
* Ex:
    Imagine a scenario of 50 tables all referencing one table. You did cascading delete operation and now all those 50 tables have NULL values and trying to clean your database will be a massive hassle. 
* It is possible to also just delete the row instead of putting NULL values but then that leads to massive lose of information so... lose lose situation either way
## Indexing
* Didn't go over because it is also not relevant in our case but really useful when your database have 50 tables
* It is just a way to query data really fast from the database by... cheating almost
* Basically, it will take the most commonly done query statements in your database and just save that query result
    * So instead of doing the operation, it just gives you the result right away because sql already have it stored
* Biggest con about it is just memory space since you are saving the information and that can get ridiculously big 
    * Sometimes double the size of the table