CREATE TABLE Scores(
    Id INT IDENTITY NOT NULL,
    Mark FLOAT NOT NULL CHECK(Mark >= 2 AND Mark <= 6),
	SemesterId INT NOT NULL,
	StudentId INT NOT NULL,
	DisciplineId INT NOT NULL,
	CreatedOn DATETIME NOT NULL DEFAULT(GETDATE()),
	ModifiedOn DATETIME NULL,
	IsDeleted BIT NOT NULL DEFAULT(0),
	DeletedOn DATETIME NULL,
	CONSTRAINT PK_Scores PRIMARY KEY CLUSTERED (Id ASC),
	CONSTRAINT FK_Scores_Students FOREIGN KEY (StudentId) REFERENCES Students(Id),
	CONSTRAINT FK_Scores_Semesters FOREIGN KEY (SemesterId) REFERENCES Semesters(Id),
	CONSTRAINT FK_Scores_Disciplines FOREIGN KEY (DisciplineId) REFERENCES Disciplines(Id)
);
GO

SET IDENTITY_INSERT Scores ON

INSERT INTO Scores(Id, Mark, SemesterId, StudentId, DisciplineId)
VALUES (1, 2, 1, 1, 1)

INSERT INTO Scores(Id, Mark, SemesterId, StudentId, DisciplineId)
VALUES (2, 5.23, 1, 1, 7)

INSERT INTO Scores(Id, Mark, SemesterId, StudentId, DisciplineId)
VALUES (3, 6, 2, 1, 2)

INSERT INTO Scores(Id, Mark, SemesterId, StudentId, DisciplineId)
VALUES (4, 5, 2, 1, 3)

INSERT INTO Scores(Id, Mark, SemesterId, StudentId, DisciplineId)
VALUES (5, 4.40, 3, 2, 6)

INSERT INTO Scores(Id, Mark, SemesterId, StudentId, DisciplineId)
VALUES (6, 4.50, 3, 2, 1)

INSERT INTO Scores(Id, Mark, SemesterId, StudentId, DisciplineId)
VALUES (7, 3.20, 4, 2, 10)

INSERT INTO Scores(Id, Mark, SemesterId, StudentId, DisciplineId)
VALUES (8, 5, 5, 3, 1)

INSERT INTO Scores(Id, Mark, SemesterId, StudentId, DisciplineId)
VALUES (9, 6, 6, 3, 3)

INSERT INTO Scores(Id, Mark, SemesterId, StudentId, DisciplineId)
VALUES (10, 4, 6, 6, 2)

SET IDENTITY_INSERT Scores OFF
GO