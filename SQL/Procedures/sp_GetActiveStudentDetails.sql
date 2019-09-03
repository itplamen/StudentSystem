USE StudentSystemDb
GO

USE StudentSystemDb
GO

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
		professors.CreatedOn AS [ProfessorCreatedOn],
		professors.ModifiedOn AS [ProfessorModifiedOn],
		professors.IsDeleted AS [ProfessorIsDeleted],
		professors.DeletedOn AS [ProfessorDeletedOn],
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
		ProfessorLastName AS [LastName],
		ProfessorCreatedOn AS [CreatedOn],
		ProfessorModifiedOn AS [ModifiedOn],
		ProfessorIsDeleted AS [IsDeleted],
		ProfessorDeletedOn AS [DeletedOn]
	FROM #ActiveStudentDetails
	GROUP BY 
		ProfessorId,
		ProfessorFirstName,
		ProfessorLastName,
		ProfessorCreatedOn,
		ProfessorModifiedOn,
		ProfessorIsDeleted,
		ProfessorDeletedOn

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