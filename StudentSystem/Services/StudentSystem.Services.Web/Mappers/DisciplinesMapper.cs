namespace StudentSystem.Services.Web.Mappers
{
    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Disciplines;
    using StudentSystem.Services.Models.Web.Semesters;
    using StudentSystem.Services.Web.Mappers.Base;

    public class DisciplinesMapper : BaseMapper<Discipline, DisciplineResponseModel>
    {
        private readonly IMapper<Semester, SemesterResponseModel> semestersMapper;

        public DisciplinesMapper(IMapper<Semester, SemesterResponseModel> semestersMapper)
        {
            this.semestersMapper = semestersMapper;
        }

        public override DisciplineResponseModel Map(Discipline from)
        {
            DisciplineResponseModel discipline = new DisciplineResponseModel()
            {
                Id = from.Id,
                CreatedOn = from.CreatedOn,
                ModifiedOn = from.ModifiedOn,
                Name = from.Name,
                SemesterId = from.SemesterId,
                ProfessorId = from.ProfessorId,
                Semester = semestersMapper.Map(from.Semester)
            };

            return discipline;
        }
    }
}