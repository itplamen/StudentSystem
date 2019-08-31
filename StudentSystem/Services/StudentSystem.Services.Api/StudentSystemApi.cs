namespace StudentSystem.Services.Api
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using StudentSystem.Services.Api.Contracts;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public class StudentSystemApi : IStudentSystemApi
    {
        private readonly StudentsServiceClient studentsService;

        public StudentSystemApi(StudentsServiceClient studentsService)
        {
            this.studentsService = studentsService;
        }

        public async Task<IEnumerable<SemesterResponseModel>> GetStudentDetailsAsync()
        {
            IEnumerable<SemesterResponseModel> response = await studentsService.GetAsync();
            studentsService.Close();

            return response;
        }
    }
}