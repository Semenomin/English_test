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
