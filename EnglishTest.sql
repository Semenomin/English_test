use englishtest;
go
create table Users
(
ID tinyint identity(0,1) primary key,
Login_text nvarchar(20) not null,
Password_text nvarchar(50) not null,
Name_user nvarchar(30) not null
)

create table Progress
(
ID tinyint identity(0,1) primary key,
Id_user tinyint not null,
Last_Chapter tinyint not null check(Last_Chapter between 1 and 18),
Last_Chapter_page tinyint not null,
Words tinyint not null,
time_in time not null
)