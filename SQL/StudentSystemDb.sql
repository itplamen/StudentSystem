USE master
GO

CREATE DATABASE StudentSystemDb
GO

USE StudentSystemDb
GO

-------------------- Create Students --------------------

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

-------------------- Create Semesters --------------------

CREATE TABLE Semesters(
    Id INT IDENTITY NOT NULL,
    Name NVARCHAR(50) NOT NULL,
	StartDate DATE NOT NULL,
	EndDate DATE NOT NULL,
	CreatedOn DATETIME NOT NULL DEFAULT(GETDATE()),
	ModifiedOn DATETIME NULL,
	IsDeleted BIT NOT NULL DEFAULT(0),
	DeletedOn DATETIME NULL,
	CONSTRAINT PK_Semesters PRIMARY KEY CLUSTERED (Id ASC),
	CONSTRAINT AK_Semesters_Name UNIQUE NONCLUSTERED (Name)
);
GO

CREATE NONCLUSTERED INDEX IX_Semesters_Name ON Semesters (Name)
GO

SET IDENTITY_INSERT Semesters ON

INSERT INTO Semesters(Id, Name, StartDate, EndDate)
VALUES (1, 'Fall 2016/2017', '2016-09-15', '2017-01-15')

INSERT INTO Semesters(Id, Name, StartDate, EndDate)
VALUES (2, 'Spring 2017', '2017-02-20', '2017-07-20')

INSERT INTO Semesters(Id, Name, StartDate, EndDate)
VALUES (3, 'Fall 2017/2018', '2017-09-15', '2018-01-15')

INSERT INTO Semesters(Id, Name, StartDate, EndDate)
VALUES (4, 'Spring 2018', '2018-02-20', '2018-07-20')

INSERT INTO Semesters(Id, Name, StartDate, EndDate)
VALUES (5, 'Fall 2018/2019', '2018-09-15', '2019-01-15')

INSERT INTO Semesters(Id, Name, StartDate, EndDate)
VALUES (6, 'Spring 2019', '2019-02-20', '2019-07-20')

SET IDENTITY_INSERT Semesters OFF
GO

-------------------- Create Professors --------------------

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

-------------------- Create Disciplines --------------------

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

-------------------- Create Scores --------------------

CREATE TABLE Scores(
    Id INT IDENTITY NOT NULL,
    Mark FLOAT NOT NULL CHECK(Mark >= 2 AND Mark <= 6),
	StudentId INT NOT NULL,
	DisciplineId INT NOT NULL,
	CreatedOn DATETIME NOT NULL DEFAULT(GETDATE()),
	ModifiedOn DATETIME NULL,
	IsDeleted BIT NOT NULL DEFAULT(0),
	DeletedOn DATETIME NULL,
	CONSTRAINT PK_Scores PRIMARY KEY CLUSTERED (Id ASC),
	CONSTRAINT FK_Scores_Students FOREIGN KEY (StudentId) REFERENCES Students(Id),
	CONSTRAINT FK_Scores_Disciplines FOREIGN KEY (DisciplineId) REFERENCES Disciplines(Id)
);
GO

SET IDENTITY_INSERT Scores ON

INSERT INTO Scores(Id, Mark, StudentId, DisciplineId)
VALUES (1, 2, 1, 1)

INSERT INTO Scores(Id, Mark, StudentId, DisciplineId)
VALUES (2, 5.23, 1, 7)

INSERT INTO Scores(Id, Mark, StudentId, DisciplineId)
VALUES (3, 6, 1, 2)

INSERT INTO Scores(Id, Mark, StudentId, DisciplineId)
VALUES (4, 5, 1, 3)

INSERT INTO Scores(Id, Mark, StudentId, DisciplineId)
VALUES (5, 4.40, 2, 6)

INSERT INTO Scores(Id, Mark, StudentId, DisciplineId)
VALUES (6, 4.50, 2, 1)

INSERT INTO Scores(Id, Mark, StudentId, DisciplineId)
VALUES (7, 3.20, 2, 10)

INSERT INTO Scores(Id, Mark, StudentId, DisciplineId)
VALUES (8, 5,  3, 1)

INSERT INTO Scores(Id, Mark, StudentId, DisciplineId)
VALUES (9, 6, 3, 3)

INSERT INTO Scores(Id, Mark, StudentId, DisciplineId)
VALUES (10, 4, 6, 2)

SET IDENTITY_INSERT Scores OFF
GO

-------------------- Create sp_GetActiveStudentDetails procedure --------------------

CREATE PROCEDURE [dbo].[sp_GetActiveStudentDetails]
AS

BEGIN

	IF(OBJECT_ID('tempdb..#ActiveStudentDetails') IS NOT NULL) 
	BEGIN
		DROP TABLE #ActiveStudentDetails
	END

	SELECT 
		students.Id AS [StudentId], 
		students.FirstName AS [StudentFirstName], 
		students.LastName AS [StudentLastName],
		students.Email AS [StudentEmail], 
		students.DateOfBirth AS [StudentDateOfBirth],
		students.CreatedOn AS [StudentCreatedOn],
		students.ModifiedOn AS [StudentModifiedOn],
		semesters.Id AS [SemesterId],
		semesters.Name AS [SemesterName],
		semesters.StartDate AS [SemesterStarDate],
		semesters.EndDate AS [SemesterEndDate],
		disciplines.Id AS [DisciplineId],
		disciplines.Name AS [DisciplineName],
		professors.Id AS [ProfessorId],
		professors.FirstName AS [ProfessorFirstName],
		professors.LastName AS [ProfessorLastName],
		scores.Mark AS [Mark]
	INTO #ActiveStudentDetails
	FROM [dbo].[Students] students
	INNER JOIN [dbo].[Scores] scores ON scores.StudentId = students.Id
	INNER JOIN [dbo].[Disciplines] disciplines ON disciplines.Id = scores.DisciplineId
	INNER JOIN [dbo].[Semesters] semesters ON semesters.Id = disciplines.SemesterId
	INNER JOIN [dbo].[Professors] professors ON professors.Id = disciplines.ProfessorId
	WHERE students.IsDeleted = 0

	-- Semesters
	SELECT 
		SemesterId AS [Id],
		SemesterName AS [Name],
		SemesterStarDate AS [StartDate],
		SemesterEndDate AS [EndDate]
	FROM #ActiveStudentDetails
	GROUP BY 
		SemesterId,
		SemesterName,
		SemesterStarDate,
		SemesterEndDate

	-- Disciplines
	SELECT 
		DisciplineId AS [Id],
		DisciplineName AS [Name],
		SemesterId AS [SemesterId],
		ProfessorId AS [ProfessorId]
	FROM #ActiveStudentDetails
	GROUP BY 
		DisciplineId,
		DisciplineName,
		SemesterId,
		ProfessorId

	-- Professors
	SELECT 
		ProfessorId AS [Id],
		ProfessorFirstName AS [FirstName],
		ProfessorLastName AS [LastName]
	FROM #ActiveStudentDetails
	GROUP BY 
		ProfessorId,
		ProfessorFirstName,
		ProfessorLastName

	--Scores
	SELECT 
		Mark AS [Mark],
		StudentId AS [StudentId],
		DisciplineId AS [DisciplineId]
	FROM #ActiveStudentDetails

	-- Students
    SELECT 
		StudentId AS [Id], 
		StudentFirstName AS [FirstName],
		StudentLastName AS [LastName],
		StudentEmail AS [Email],
		StudentDateOfBirth AS [DateOfBirth],
		StudentCreatedOn AS [CreatedOn],
		StudentModifiedOn AS [ModifiedOn]
	FROM #ActiveStudentDetails
	GROUP BY 
		StudentId, 
		StudentFirstName,
		StudentLastName,
		StudentEmail,
		StudentDateOfBirth,
		StudentCreatedOn,
		StudentModifiedOn

	DROP TABLE #ActiveStudentDetails

END