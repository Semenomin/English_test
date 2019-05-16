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
Id_user tinyint foreign key references Users(Id),
Last_Chapter tinyint not null default(0),
Last_Chapter_page tinyint not null default(0),
Words tinyint not null default(0),
time_in nvarchar(100) not null default('0')
)

create table Vocabulary
(
Id tinyint identity(1,1) not null primary key,
Word nvarchar(70) not null,
Trans nvarchar(70) not null,
)
create table User_vocabulary
(
Id tinyint identity(1,1) not null primary key,
Id_user tinyint foreign key references Users(id),
Id_Voc tinyint foreign key references Vocabulary(Id),
Word nvarchar(70) not null,
Trans nvarchar(70) not null,
good int not null default(0),
bad int not null default(0),
)

INSERT INTO Vocabulary (word,Trans) values
('human','�������'),
('strange','��������'),
('love','������'),
('international','�������������'),
('native speaker','��������'),
('spread','����������������'),
('talk in broken English','�������� �� �������� ����������'),
('find a common language','����� ����� ����'),
('leading economic power','������� ������������� �������'),
('prominent = outstanding = famous','����������'),
('a debt','����'),
('a dime','�������'),
('a prophesy','�����������'),
('a crusader','�����'),
('a legacy','����������'),
('to staple','��������'),
('to be calm','���� ���������'),
('a hatchet','�����'),
('a caving','���������'),
('to overwhelm','����������'),
('an ease','��������'),
('anxious','���������'),
('to crawl','�������'),
('amount','����������'),
('to spoil','�������'),
('addiction','�����������'),
('retail','���������'),
('a receipt','���������'),
('to brag','����������'),
('a rack','�������'),
('to stack','������������'),
('to swing','�������������'),
('to count','�������'),
('a rope','�������'),
('a vine','�������'),
('a shot','����'),
('a turning','�������'),
('to apalogize','������� ��������'),
('to hold','�������'),
('hidden','�������'),
('flame','�����'),
('to lead','���������'),
('to crash','�����������'),
('a slick','�������������'),
('a fading','���������'),
('to cause','��������'),
('to burn','����'),
('to booth','�����'),
('to loop','�����'),
('to loot','�������'),
('a budget','������'),
('a giant','����������'),
('beneficial','��������'),
('to drag','������'),
('fair','������������'),
('to keep','����������'),
('trouble','��������'),
('savage','�����'),
('a check','��������'),
('to match','��������')

USE englishtest;
GO
CREATE PROCEDURE GetLogins @Login NVARCHAR(50) AS
Select id from Users where Login_text = @Login 
go 
CREATE PROCEDURE CreateProgress @Id tinyint AS
INSERT into Progress (Id_user) values(@Id)
go 
CREATE PROCEDURE ValidateUser @username NvarCHAR(50) AS
Select Login_text from Users where Login_text like @username
go 
CREATE PROCEDURE CreateUser @username NvarCHAR(50), @password NvarCHAR(50), @name NvarCHAR(50) AS
INSERT INTO Users (Login_text,Password_text,Name_user) VALUES (@username, @password, @name)
go 
CREATE PROCEDURE LogInUser @username NvarCHAR(50), @password NvarCHAR(50) AS
Select Id,Name_user from Users where Login_text like @username and Password_text like @password
GO
CREATE PROCEDURE GetProgress @Id tinyint AS
Select * from Progress where id_user=@Id
GO
CREATE PROCEDURE GetDictionary @Id tinyint AS
SELECT * FROM User_vocabulary where Id_user=@id
go
CREATE PROCEDURE UpdateProgress @Last_Chapter tinyint, @Last_Chapter_page tinyint, @Words tinyint, @time_i NvarCHAR(50), @id_user tinyint AS
Update Progress set Last_Chapter=@Last_Chapter,Last_Chapter_page=@Last_Chapter_page,Words=@Words,time_in=@time_i where id_user=@id_user
GO
CREATE PROCEDURE GetCountWords AS
Select Count(id) from Vocabulary
GO
CREATE PROCEDURE GetUserWords AS
Select * from User_vocabulary
GO
CREATE PROCEDURE GetRandomWord @id tinyint AS
Select Word,Trans from Vocabulary where Id=@id
GO
CREATE PROCEDURE ClearVacabulary @id tinyint AS
delete from User_vocabulary where Id_user=@id
GO
CREATE PROCEDURE GetWord @id tinyint AS
Select * from Vocabulary where Id = @id
go 
CREATE PROCEDURE CreateVocabulary @Id_user tinyint, @Id_Voc tinyint, @Word NvarCHAR(50), @Trans NvarCHAR(50) AS
INSERT INTO User_vocabulary (Id_user,Id_Voc,Word,Trans) values (@Id_user,@Id_Voc,@Word,@Trans)
GO
CREATE PROCEDURE GetWordsToTest @id tinyint AS
Select * from User_vocabulary where good-bad!=3 and id_user=@id order by id_voc
GO
CREATE PROCEDURE GetAnswersToTest @id tinyint AS
Select * from User_vocabulary where good-bad!=3 and id_user=@id order by id_Voc desc
GO
CREATE PROCEDURE GetIdByWord @Word NvarCHAR(50) AS
Select id from User_vocabulary where Word = @Word
GO
CREATE PROCEDURE GetIdByTrans @Trans NvarCHAR(50) AS
Select id from User_vocabulary where Trans = @Trans
GO
CREATE PROCEDURE UpdateGoodWord @id tinyint AS
Update User_vocabulary set good = good + 1 where id=@id
GO
CREATE PROCEDURE UpdateBadWord @id_word tinyint,@id_trans tinyint AS
Update User_vocabulary set bad = bad + 1 where id=@id_word or id=@id_trans