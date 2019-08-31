namespace StudentSystem.Services.Api.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using StudentSystem.Services.Api.StudentsServiceSoap;

    public interface IStudentSystemApi
    {
        Task<IEnumerable<SemesterResponseModel>> GetStudentDetailsAsync();
    }
}