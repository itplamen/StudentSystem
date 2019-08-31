namespace StudentSystem.Services.Web.Mappers
{
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Professors;
    using StudentSystem.Services.Web.Mappers.Base;

    public class ProfessorsMapper : BaseMapper<Professor, ProfessorResponseModel>
    {
        public override ProfessorResponseModel Map(Professor from)
        {
            ProfessorResponseModel professor = new ProfessorResponseModel()
            {
                Id = from.Id,
                CreatedOn = from.CreatedOn,
                ModifiedOn = from.ModifiedOn,
                FirstName = from.FirstName,
                LastName = from.LastName
            };

            return professor;
        }
    }
}