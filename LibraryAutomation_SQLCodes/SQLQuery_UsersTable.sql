CREATE TABLE Users (
	userr_id INT IDENTITY(1,1) PRIMARY KEY,
	userr_name NVARCHAR(50) NULL,
	user_lastname NVARCHAR(50) NULL,
	user_gender NVARCHAR(1) NULL,
	user_TC NVARCHAR(11) NULL,
	user_phone NVARCHAR(11) NULL,
	user_mail NVARCHAR(50) NULL,
	user_fine FLOAT NULL
);

INSERT INTO Users(userr_name, user_lastname, user_gender, user_TC, user_phone, user_mail, user_fine)
VALUES ('Suat', 'Topcu', 'M', '11111111111', '01111111111', 'suat@example.com', 0),
	   ('Elif', 'Günaz', 'F', '22222222222', '02222222222', 'elif@example.com', 0);