CREATE TABLE Professors(
    Id INT IDENTITY NOT NULL,
    FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	CreatedOn DATETIME NOT NULL DEFAULT(GETDATE()),
	ModifiedOn DATETIME NULL,
	IsDeleted BIT NOT NULL DEFAULT(0),
	DeletedOn DATETIME NULL,
	CONSTRAINT PK_Professors PRIMARY KEY CLUSTERED (Id ASC)
);
GO

SET IDENTITY_INSERT Professors ON

INSERT INTO Professors(Id, FirstName, LastName)
VALUES (1, 'Jossef', 'Goldberg')

INSERT INTO Professors(Id, FirstName, LastName)
VALUES (2, 'Sidney', 'Higa')

INSERT INTO Professors(Id, FirstName, LastName)
VALUES (3, 'Taylor', 'Maxwell')

SET IDENTITY_INSERT Professors OFF
GO