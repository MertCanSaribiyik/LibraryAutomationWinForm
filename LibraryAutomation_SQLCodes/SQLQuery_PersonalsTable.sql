CREATE TABLE Personals (
	personal_id INT IDENTITY(1,1) PRIMARY KEY,
	Personal_name NVARCHAR(50) NULL,
	Personal_lastname NVARCHAR(50) NULL,
	Personal_TC NVARCHAR(11) NULL,
	Personal_phone NVARCHAR(11) NULL,
	Personal_mail NVARCHAR(50) NULL,
	Personal_userName NVARCHAR(50) NULL,
	Personal_password NVARCHAR(50) NULL
);

INSERT INTO Personals (Personal_name, Personal_lastname, Personal_TC, Personal_phone, Personal_mail, Personal_userName, Personal_password)
VALUES ('Mert Can', 'Sarýbýyýk', '11111111111', '01111111111', 'mert@example.com', 'Typerex', '1'),
	   ('Yavuz Selim', 'Güner', '22222222222', '02222222222', 'yavuz@example.com', 'Yavuz', '2'),
	   ('Mustafa Samed', 'Özþahin', '33333333333', '03333333333', 'samed@example.com', 'Lalo', '3'),
	   ('Furkan', 'Çevik', '44444444444', '04444444444', 'furkan@example.com', 'Skywalker', '4'),
	   ('Berkay', 'Köse', '55555555555', '05555555555', 'berkay@example.com', 'Berkay', '5');