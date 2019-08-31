namespace StudentSystem.Services.Web.Mappers
{
    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Disciplines;
    using StudentSystem.Services.Models.Web.Semesters;
    using StudentSystem.Services.Web.Mappers.Base;

    public class SemestersMapper : BaseMapper<Semester, SemesterResponseModel>
    {
        private readonly IMapper<Discipline, DisciplineResponseModel> disciplinesMapper;

        public SemestersMapper(IMapper<Discipline, DisciplineResponseModel> disciplinesMapper)
        {
            this.disciplinesMapper = disciplinesMapper;
        }

        public override SemesterResponseModel Map(Semester from)
        {
            SemesterResponseModel semester = new SemesterResponseModel()
            {
                Id = from.Id,
                CreatedOn = from.CreatedOn,
                ModifiedOn = from.ModifiedOn,
                Name = from.Name,
                StartDate = from.StartDate,
                EndDate = from.EndDate,
                Disciplines = disciplinesMapper.Map(from.Disciplines)
            };

            return semester;
        }
    }
}