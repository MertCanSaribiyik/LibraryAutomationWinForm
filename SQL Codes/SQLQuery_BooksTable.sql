CREATE TABLE Books(
	book_id INT IDENTITY(1,1) PRIMARY KEY,
	book_name NVARCHAR(50) NULL,
	book_authorName NVARCHAR(50) NULL,
	book_publisher NVARCHAR(50) NULL,
	book_page INT NULL,
	book_publicationDate DATE NULL
);

INSERT INTO Books(book_name, book_authorName, book_publisher, book_page, book_publicationDate)
VALUES ('Otostop�unun Galaksi Rehberi', 'Douglas Adams', 'Alfa Yay�nc�l�k', 248, '2017-05-12'),
	   ('�nsan Neyle Ya�ar', 'L.N. Tolstoy', '�� Bankas� K�lt�r Yay�nlar�', 112, '2012-10-12');