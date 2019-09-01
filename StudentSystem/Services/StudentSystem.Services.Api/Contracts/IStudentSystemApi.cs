namespace StudentSystem.Services.Api.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using StudentSystem.Services.Api.StudentsServiceSoap;

    public interface IStudentSystemApi
    {
        Task<bool> CreateStudent(StudentRequestModel request);

        Task<IEnumerable<SemesterResponseModel>> GetStudentDetailsAsync();

        Task<bool> UpdateStudent(StudentRequestModel request);
    }
}