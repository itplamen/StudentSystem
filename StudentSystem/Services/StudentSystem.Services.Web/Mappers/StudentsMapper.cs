namespace StudentSystem.Services.Web.Mappers
{
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Students;
    using StudentSystem.Services.Web.Mappers.Base;

    public class StudentsMapper : BaseMapper<Student, StudentResponseModel>
    {
        public override StudentResponseModel Map(Student from)
        {
            StudentResponseModel studentModel = new StudentResponseModel()
            {
                Id = from.Id,
                CreatedOn = from.CreatedOn,
                ModifiedOn = from.ModifiedOn,
                FirstName = from.FirstName,
                LastName = from.LastName,
                Email = from.Email,
                DateOfBirth = from.DateOfBirth
            };

            return studentModel;
        }
    }
}