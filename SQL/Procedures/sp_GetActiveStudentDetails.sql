CREATE PROCEDURE [dbo].[sp_GetActiveStudentDetails]
AS

BEGIN

	IF(OBJECT_ID('tempdb..#ActiveStudentDetails') IS NOT NULL) 
	BEGIN
		DROP TABLE #ActiveStudentDetails
	END

	SELECT 
		students.Id AS [StudentId], 
		students.FirstName + ' ' + students.LastName AS [StudentName], 
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
		professors.FirstName + ' ' + professors.LastName AS [ProfessorName],
		scores.Mark AS [Score]
	INTO #ActiveStudentDetails
	FROM [dbo].[Students] students
	INNER JOIN [dbo].[Scores] scores ON scores.StudentId = students.Id
	INNER JOIN [dbo].[Disciplines] disciplines ON disciplines.Id = scores.DisciplineId
	INNER JOIN [dbo].[Semesters] semesters ON semesters.Id = disciplines.SemesterId
	INNER JOIN [dbo].[Professors] professors ON professors.Id = disciplines.ProfessorId
	WHERE students.IsDeleted = 0

	-- Students
    SELECT 
		StudentId, 
		StudentName,
		StudentEmail,
		StudentDateOfBirth,
		StudentCreatedOn,
		StudentModifiedOn
	FROM #ActiveStudentDetails
	GROUP BY 
		StudentId, 
		StudentName,
		StudentEmail,
		StudentDateOfBirth,
		StudentCreatedOn,
		StudentModifiedOn

	-- Semesters
	SELECT 
		SemesterId,
		SemesterName,
		SemesterStarDate,
		SemesterEndDate,
		StudentId
	FROM #ActiveStudentDetails
	GROUP BY 
		SemesterId,
		SemesterName,
		SemesterStarDate,
		SemesterEndDate,
		StudentId

	--Disciplines
	SELECT 
		DisciplineId,
		DisciplineName,
		StudentId,
		ProfessorId,
		ProfessorName,
		Score
	FROM #ActiveStudentDetails

	DROP TABLE #ActiveStudentDetails

END