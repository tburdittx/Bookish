--create table
CREATE TABLE dbo.Books
	(bookID INT IDENTITY PRIMARY KEY,
	ISBN NVARCHAR(26) NOT NULL,
	Title NVARCHAR(25) NOT NULL,
	Author NVARCHAR(25) NOT NULL,
	Barcode NVARCHAR(26) NOT NULL)
	GO 