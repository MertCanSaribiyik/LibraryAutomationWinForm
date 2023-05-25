CREATE TABLE Records(
	record_id INT IDENTITY(1,1) PRIMARY KEY,
	userr_id INT FOREIGN KEY REFERENCES Users(userr_id) NULL,		
	book_id INT FOREIGN KEY REFERENCES Books(book_id) NULL,
	startDate DATE NULL,
	finishDate DATE NULL,
	statuss BIT NULL
);