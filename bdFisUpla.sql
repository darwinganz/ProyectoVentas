create database dbFisUpla
use dbFisUpla
go

create table estudiante (
id int identity(1,1) NOT NULL PRIMARY KEY,
Num_doc varchar(8) NOT NULL unique,
Nombres varchar(20) NOT NULL,
Email varchar (30) NOT NULL,
estado bit NOT NULL
)

create table docente (
id int identity(1,1) NOT NULL PRIMARY KEY,
Num_doc varchar(8)NOT NULL unique,
Nombres varchar(20),
Horaentrada datetime NOT NULL
)

insert into estudiante values ('67890654','Juan Perez', 'juan@gmail.com',1);
insert into estudiante values ('67896654','Maria Perez', 'maria@gmail.com',1);
insert into estudiante values ('67899654','Julia Perez', 'julia@gmail.com',1);

insert into docente values ('67890654','Waldir Rojas', '2024-05-17 09:00:00');

