use englishtest;
go
create table User_vocabulary
(
Id tinyint identity(1,1) not null primary key,
Id_user tinyint foreign key references Users(id),
Id_Voc tinyint foreign key references Vocabulary(Id),
Word nvarchar(70) not null,
Trans nvarchar(70) not null,
good tinyint not null default(0),
bad tinyint not null default(0),
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
Id_user tinyint not null,
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
