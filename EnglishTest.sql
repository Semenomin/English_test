use englishtest;
go
create table User_vocabulary
(
Id int identity(1,1) not null primary key,
Id_user tinyint foreign key references Users(id),
Id_Voc tinyint foreign key references Vocabulary(Id),
Word nvarchar(70) not null,
Trans nvarchar(70) not null,
good int not null default(0),
bad int not null default(0),
)
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


INSERT INTO Vocabulary (word,Trans) values
('human','человек'),
('strange','странный'),
('love','любить'),
('international','международный'),
('native speaker','носитель'),
('spread','распространяться'),
('talk in broken English','говорить на ломанном английском'),
('find a common language','найти общий язык'),
('leading economic power','ведущая экономическая держава'),
('prominent = outstanding = famous','знаменитый'),
('a debt','долг'),
('a dime','копейка'),
('a prophesy','пророчество'),
('a crusader','борец'),
('a legacy','наследство'),
('to staple','скрепить'),
('to be calm','быть спокойным'),
('a hatchet','топор'),
('a caving','обрушение'),
('to overwhelm','ошеломлять'),
('an ease','простота'),
('anxious','тревожный'),
('to crawl','ползать'),
('amount','количество'),
('to spoil','портить'),
('addiction','зависимость'),
('retail','розничный'),
('a receipt','квитанция'),
('to brag','хвастаться'),
('a rack','стеллаж'),
('to stack','нагромождать'),
('to swing','раскачиваться'),
('to count','считать'),
('a rope','веревка'),
('a vine','спираль'),
('a shot','удар'),
('a turning','поворот'),
('to apalogize','просить прощения'),
('to hold','держать'),
('hidden','скрытый'),
('flame','пламя'),
('to lead','проводить'),
('to crash','разбиваться'),
('a slick','приглаживание'),
('a fading','замирание'),
('to cause','вызывать'),
('to burn','жечь'),
('to booth','киоск'),
('to loop','петля'),
('to loot','грабить'),
('a budget','бюджет'),
('a giant','гигантский'),
('beneficial','выгодный'),
('to drag','тащить'),
('fair','справедливый'),
('to keep','продолжать'),
('trouble','проблема'),
('savage','дикий'),
('a check','проверка'),
('to match','сочетать')

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
CREATE PROCEDURE GetUserWords @id tinyint AS
Select * from User_vocabulary where Id_user = @id
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
CREATE PROCEDURE CreateVocabulary @Id_user int, @Id_Voc int, @Word NvarCHAR(50), @Trans NvarCHAR(50),@Good tinyint,@bad tinyint AS
INSERT INTO User_vocabulary (Id_user,Id_Voc,Word,Trans,good,bad) values (@Id_user,@Id_Voc,@Word,@Trans,@good,@bad)
GO
CREATE PROCEDURE GetWordsToTest @id tinyint AS
Select * from User_vocabulary where good-bad!=1 and id_user=@id order by id_voc
GO
CREATE PROCEDURE GetAnswersToTest @id tinyint AS
Select * from User_vocabulary where good-bad!=1 and id_user=@id order by id_Voc desc
GO
CREATE PROCEDURE GetIdByWord @Word NvarCHAR(50) AS
Select id from User_vocabulary where Word = @Word
GO
CREATE PROCEDURE GetIdByTrans @Trans NvarCHAR(50) AS
Select id from User_vocabulary where Trans = @Trans
GO
CREATE PROCEDURE UpdateGoodWord @id int AS
Update User_vocabulary set good = good + 1 where id=@id
GO
CREATE PROCEDURE UpdateBadWord @id_word int,@id_trans int AS
Update User_vocabulary set bad = bad + 1 where id=@id_word or id=@id_trans
GO
CREATE PROCEDURE AddWordInVocabulary @word NvarCHAR(50),@Trans NvarCHAR(50) AS
INSERT INTO Vocabulary (Word,Trans) values (@word,@Trans)
GO
CREATE PROCEDURE RestorePassword @Login NvarCHAR(50) AS
SELECT Password_text FROM Users where Login_text = @Login
GO
CREATE PROCEDURE ResetProgress @Login NvarCHAR(50) AS
begin
UPDATE Progress Set Last_Chapter=0,Last_Chapter_page=0,time_in=0,Words =0 where Id_user=(select id from Users where Login_text = @Login)
Delete  from User_vocabulary where Id_user = (select id from Users where Login_text = @Login)
end
GO
CREATE PROCEDURE GetLeanredWords @id tinyint AS
Begin
Update Progress set Words =(Select Count(*) from User_vocabulary where good-bad>=1 and id_user=@id) where Id_user=@id
Select Words from Progress where id_user=@id
end;
GO
CREATE PROCEDURE GetChapters @id tinyint AS
Select Last_Chapter,Last_chapter_page from progress where Id_user = @id