namespace StudentSystem.Services.Web.Mappers
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web.Students;

    public class StudentsMapper : IMapper<Student, StudentResponseModel>
    {
        public StudentResponseModel Map(Student from)
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

        public IEnumerable<StudentResponseModel> Map(IEnumerable<Student> from)
        {
            ICollection<StudentResponseModel> studentModels = new List<StudentResponseModel>();

            foreach (var student in from)
            {
                StudentResponseModel studentModel = Map(student);

                studentModels.Add(studentModel);
            }

            return studentModels;
        }
    }
}