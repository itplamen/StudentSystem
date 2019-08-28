CREATE TABLE Disciplines(
    Id INT IDENTITY NOT NULL,
    Name NVARCHAR(100) NOT NULL,
	CreatedOn DATETIME NOT NULL DEFAULT(GETDATE()),
	ModifiedOn DATETIME NULL,
	IsDeleted BIT NOT NULL DEFAULT(0),
	DeletedOn DATETIME NULL,
	CONSTRAINT PK_Disciplines PRIMARY KEY CLUSTERED (Id ASC),
	CONSTRAINT AK_Disciplines_Name UNIQUE NONCLUSTERED (Name)
);
GO

SET IDENTITY_INSERT Disciplines ON

INSERT INTO Disciplines(Id, Name)
VALUES (1, 'Programming Fundamentals')

INSERT INTO Disciplines(Id, Name)
VALUES (2, 'C# OOP')

INSERT INTO Disciplines(Id, Name)
VALUES (3, 'Linux System Administration')

INSERT INTO Disciplines(Id, Name)
VALUES (4, 'Ethical Hacking')

INSERT INTO Disciplines(Id, Name)
VALUES (5, 'HTML & CSS')

INSERT INTO Disciplines(Id, Name)
VALUES (6, 'Quality Assurance')

INSERT INTO Disciplines(Id, Name)
VALUES (7, 'Windows System Administration')

INSERT INTO Disciplines(Id, Name)
VALUES (8, 'Microcontrollers')

INSERT INTO Disciplines(Id, Name)
VALUES (9, 'C++ Advanced')

INSERT INTO Disciplines(Id, Name)
VALUES (10, 'WPF Essentials')

SET IDENTITY_INSERT Disciplines OFF
GO