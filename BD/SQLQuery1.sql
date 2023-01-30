CREATE DATABASE GA1
USE GA1
CREATE TABLE LOGIN1(
Usuario varchar(20) not null primary key,
Contraseña varchar(20) not null,
Roll varchar (21)
);

Insert into LOGIN1 Values ('Iker2050','51si','Secretaria')

Insert into LOGIN1 Values ('Gadman2030','Whot1','Administrador')

Insert into LOGIN1 Values ('Devany','Prep23','Usuario')

CREATE TABLE CRUD(
ID INT IDENTITY NOT NULL PRIMARY KEY,
Nombre varchar(20) not null,
Correo varchar(25) not null,
Pais varchar(20) not null,
Ocupacion varchar(20) not null
);

Insert into CRUD values ('Iker','Iker@gmail.com','Honduras','Secretaria')

SELECT*FROM CRUD
SELECT*FROM LOGIN1
