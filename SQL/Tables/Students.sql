CREATE TABLE Students(
    Id INT IDENTITY NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Email NVARCHAR(50) NOT NULL CHECK(Email LIKE '%_@__%.__%'),
	DateOfBirth DATE NOT NULL,
	CreatedOn DATETIME NOT NULL DEFAULT(GETDATE()),
	ModifiedOn DATETIME NULL,
	IsDeleted BIT NOT NULL DEFAULT(0),
	DeletedOn DATETIME NULL,
	CONSTRAINT PK_Students PRIMARY KEY CLUSTERED (Id ASC)
);
GO

SET IDENTITY_INSERT Students ON

INSERT INTO Students(Id, FirstName, LastName, Email, DateOfBirth)
VALUES (1, 'Guy', 'Gilbert', 'g@gd.com', '1991-08-08')

INSERT INTO Students (Id, FirstName, LastName, Email, DateOfBirth)
VALUES (2, 'Kevin', 'Brown', 'k_brown@gmai.com', '1991-12-12')

INSERT INTO Students (Id, FirstName, LastName, Email, DateOfBirth)
VALUES (3, 'Roberto', 'Tamburello', 'rob@test.bg', '1993-06-13')

INSERT INTO Students (Id, FirstName, LastName, Email, DateOfBirth)
VALUES (4, 'Rob', 'Walters', 'rob@hotmail.net', '1992-09-01')

INSERT INTO Students (Id, FirstName, LastName, Email, DateOfBirth)
VALUES (5, 'Thierry', 'D''Hers', 'therry_d@gmail.com', '1991-03-24')

INSERT INTO Students (Id, FirstName, LastName, Email, DateOfBirth)
VALUES (6, 'David', 'Bradley', 'david@abv.bg', '1990-05-16')

INSERT INTO Students (Id, FirstName, LastName, Email, DateOfBirth)
VALUES (7, 'JoLynn', 'Dobney', 'dobney@mail.com', '1991-08-08')

INSERT INTO Students (Id, FirstName, LastName, Email, DateOfBirth)
VALUES (8, 'Ruth', 'Ellerbrock', 'ruth@mail.net', '1992-11-11')

INSERT INTO Students (Id, FirstName, LastName, Email, DateOfBirth)
VALUES (9, 'Gail', 'Erickson', 'g_e@gmail.com', '1991-12-23')

INSERT INTO Students (Id, FirstName, LastName, Email, DateOfBirth)
VALUES (10, 'Barry', 'Johnson', 'b_j@gmail.com', '1991-08-28')

SET IDENTITY_INSERT Students OFF
GO