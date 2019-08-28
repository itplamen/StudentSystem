namespace StudentSystem.Services.Web.Mappers
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models;
    using StudentSystem.Services.Models.Web;

    public class StudentsMapper : IMapper<Student, StudentModel>
    {
        public StudentModel Map(Student from)
        {
            StudentModel studentModel = new StudentModel()
            {
                Id = from.Id,
                CreatedOn = from.CreatedOn,
                ModifiedOn = from.ModifiedOn,
                IsDeleted = from.IsDeleted,
                DeletedOn = from.DeletedOn,
                FirstName = from.FirstName,
                LastName = from.LastName,
                Email = from.Email,
                DateOfBirth = from.DateOfBirth
            };

            return studentModel;
        }

        public IEnumerable<StudentModel> Map(IEnumerable<Student> from)
        {
            ICollection<StudentModel> studentModels = new List<StudentModel>();

            foreach (var student in from)
            {
                StudentModel studentModel = Map(student);

                studentModels.Add(studentModel);
            }

            return studentModels;
        }
    }
}