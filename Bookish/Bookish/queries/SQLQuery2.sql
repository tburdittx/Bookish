-- Create Table
CREATE TABLE dbo.Customers 
    (CUSTOMERID INT IDENTITY PRIMARY KEY,
    FirstName NVARCHAR(20) NOT NULL,
    Surname NVARCHAR(20) NOT NULL,
    TelephoneNumber NVARCHAR(20) NOT NULL,
    EmailAddress NVARCHAR(20) NOT NULL,
    Username NVARCHAR(20) NOT NULL,
    Password NVARCHAR(20) NOT NULL,)
	GO