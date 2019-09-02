namespace StudentSystem.Services.Api
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using StudentSystem.Services.Api.Contracts;
    using StudentSystem.Services.Api.ProfessorsServiceSoap;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public class StudentSystemApi : IStudentSystemApi
    {
        private readonly IRequestsExecutor requestsExecutor;
        private readonly StudentsServiceClient studentsClient;
        private readonly ProfessorsServiceClient professorsClient;

        public StudentSystemApi(IRequestsExecutor requestsExecutor, StudentsServiceClient studentsClient, ProfessorsServiceClient professorsClient)
        {
            this.requestsExecutor = requestsExecutor;
            this.studentsClient = studentsClient;
            this.professorsClient = professorsClient;
        }

        public async Task<bool> CreateStudent(StudentRequestModel request)
        {
            bool isCreated = await requestsExecutor.Execute(studentsClient.CreateAsync, request);

            return isCreated;
        }

        public async Task<IEnumerable<SemesterResponseModel>> GetStudentDetailsAsync()
        {
            IEnumerable<SemesterResponseModel> response = await requestsExecutor.Execute(studentsClient.GetAsync);

            return response;
        }

        public async Task<bool> UpdateStudent(StudentRequestModel request)
        {
            bool isUpdated = await requestsExecutor.Execute(studentsClient.UpdateAsync, request);

            return isUpdated;
        }
    }
}