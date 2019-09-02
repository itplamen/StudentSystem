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