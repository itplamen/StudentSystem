namespace StudentSystem.Services.Web.Mappers
{
    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Disciplines;
    using StudentSystem.Services.Models.Web.Professors;
    using StudentSystem.Services.Web.Mappers.Base;

    public class ProfessorsMapper : BaseMapper<Professor, ProfessorResponseModel>
    {
        private readonly IMapper<Discipline, DisciplineResponseModel> disciplinesMapper;

        public ProfessorsMapper(IMapper<Discipline, DisciplineResponseModel> disciplinesMapper)
        {
            this.disciplinesMapper = disciplinesMapper;
        }

        public override ProfessorResponseModel Map(Professor from)
        {
            ProfessorResponseModel professor = new ProfessorResponseModel()
            {
                Id = from.Id,
                FirstName = from.FirstName,
                LastName = from.LastName,
                CreatedOn = from.CreatedOn,
                ModifiedOn = from.ModifiedOn,
                IsDeleted = from.IsDeleted,
                DeletedOn = from.DeletedOn,
                Disciplines = disciplinesMapper.Map(from.Disciplines)
            };

            return professor;
        }
    }
}