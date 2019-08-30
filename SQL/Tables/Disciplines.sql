CREATE TABLE Disciplines(
    Id INT IDENTITY NOT NULL,
    Name NVARCHAR(100) NOT NULL,
	SemesterId INT NOT NULL,
	ProfessorId INT NOT NULL,
	CreatedOn DATETIME NOT NULL DEFAULT(GETDATE()),
	ModifiedOn DATETIME NULL,
	IsDeleted BIT NOT NULL DEFAULT(0),
	DeletedOn DATETIME NULL,
	CONSTRAINT PK_Disciplines PRIMARY KEY CLUSTERED (Id ASC),
	CONSTRAINT AK_Disciplines_Name UNIQUE NONCLUSTERED (Name),
	CONSTRAINT FK_Disciplines_Semesters FOREIGN KEY (SemesterId) REFERENCES Semesters(Id),
	CONSTRAINT FK_Disciplines_Professors FOREIGN KEY (ProfessorId) REFERENCES Professors(Id)
);
GO

SET IDENTITY_INSERT Disciplines ON

INSERT INTO Disciplines(Id, Name, SemesterId, ProfessorId)
VALUES (1, 'Programming Fundamentals', 1, 1)

INSERT INTO Disciplines(Id, Name, SemesterId, ProfessorId)
VALUES (2, 'C# OOP', 1, 1)

INSERT INTO Disciplines(Id, Name, SemesterId, ProfessorId)
VALUES (3, 'Linux System Administration', 2, 1)

INSERT INTO Disciplines(Id, Name, SemesterId, ProfessorId)
VALUES (4, 'Ethical Hacking', 2, 2)

INSERT INTO Disciplines(Id, Name, SemesterId, ProfessorId)
VALUES (5, 'HTML & CSS', 3, 2)

INSERT INTO Disciplines(Id, Name, SemesterId, ProfessorId)
VALUES (6, 'Quality Assurance', 3, 2)

INSERT INTO Disciplines(Id, Name, SemesterId, ProfessorId)
VALUES (7, 'Windows System Administration', 4, 3)

INSERT INTO Disciplines(Id, Name, SemesterId, ProfessorId)
VALUES (8, 'Microcontrollers', 4, 3)

INSERT INTO Disciplines(Id, Name, SemesterId, ProfessorId)
VALUES (9, 'C++ Advanced', 5, 3)

INSERT INTO Disciplines(Id, Name, SemesterId, ProfessorId)
VALUES (10, 'WPF Essentials', 6, 3)

SET IDENTITY_INSERT Disciplines OFF
GO