create database college;

create table NewAdmission(
NAID int NOT NULL IDENTITY(1,1) primary key,
fname varchar(250) not null,
faname varchar(250) not null,
gender varchar(10) not null,
dob varchar(50) not null,
mobile bigint not null,
email varchar(150),
semester varchar(100) not null,
prog varchar(150) not null,
duration varchar(120) not null,
addres varchar(250) not null
)
