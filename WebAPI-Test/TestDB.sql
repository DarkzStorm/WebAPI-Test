create database TestDB;

create table UserInformations(
	Id int identity(1,1) primary key,
	FullName nvarchar(255),
	Email nvarchar(255),
	PhoneNumber nvarchar(12),
	Age int
);