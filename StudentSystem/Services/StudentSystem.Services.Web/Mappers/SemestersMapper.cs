namespace StudentSystem.Services.Web.Mappers
{
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Semesters;
    using StudentSystem.Services.Web.Mappers.Base;

    public class SemestersMapper : BaseMapper<Semester, SemesterResponseModel>
    {
        public override SemesterResponseModel Map(Semester from)
        {
            SemesterResponseModel semester = new SemesterResponseModel()
            {
                Id = from.Id,
                CreatedOn = from.CreatedOn,
                ModifiedOn = from.ModifiedOn,
                Name = from.Name,
                StartDate = from.StartDate,
                EndDate = from.EndDate
            };

            return semester;
        }
    }
}