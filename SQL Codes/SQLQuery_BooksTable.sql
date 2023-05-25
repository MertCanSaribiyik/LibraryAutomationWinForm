CREATE TABLE Books(
	book_id INT IDENTITY(1,1) PRIMARY KEY,
	book_name NVARCHAR(50) NULL,
	book_authorName NVARCHAR(50) NULL,
	book_publisher NVARCHAR(50) NULL,
	book_page INT NULL,
	book_publicationDate DATE NULL
);

INSERT INTO Books(book_name, book_authorName, book_publisher, book_page, book_publicationDate)
VALUES ('Otostopçunun Galaksi Rehberi', 'Douglas Adams', 'Alfa Yayýncýlýk', 248, '2017-05-12'),
	   ('Ýnsan Neyle Yaþar', 'L.N. Tolstoy', 'Ýþ Bankasý Kültür Yayýnlarý', 112, '2012-10-12');