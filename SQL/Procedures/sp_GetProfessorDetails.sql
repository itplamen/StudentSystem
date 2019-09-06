USE StudentSystemDb
GO

CREATE PROCEDURE [dbo].[sp_GetProfessorDetails]
	@professorId INT
AS

BEGIN
	
	;WITH ProfessorDetails (
		ProfessorId, 
		ProfessorFirstName, 
		ProfessorLastName, 
		DisciplineId,
		DisciplineName,
		SemesterId,
		SemesterName,
		SemesterStarDate,
		SemesterEndDate)
	AS
	(SELECT 
		professor.Id AS [ProfessorId], 
		professor.FirstName AS [ProfessorFirstName],
		professor.LastName AS [ProfessorLastName],
		discipline.Id AS [DisciplineId],
		discipline.Name AS [DisciplineName],
		semester.Id AS [SemesterId] ,
		semester.Name AS [SemesterName],
		semester.StartDate AS [SemesterStarDate],
		semester.EndDate AS [SemesterEndDate]
	 FROM [dbo].[Professors] professor
	 JOIN [dbo].[Disciplines] discipline ON professor.Id = discipline.ProfessorId
	 JOIN [dbo].[Semesters] semester ON semester.Id = discipline.SemesterId
	 WHERE professor.Id = @professorId)

	 SELECT * FROM ProfessorDetails
	 
END