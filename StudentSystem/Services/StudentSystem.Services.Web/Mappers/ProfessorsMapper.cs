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
                FirstName = from.FirstName,
                LastName = from.LastName,
                CreatedOn = from.CreatedOn,
                ModifiedOn = from.ModifiedOn,
                IsDeleted = from.IsDeleted,
                DeletedOn = from.DeletedOn
            };

            return professor;
        }
    }
}