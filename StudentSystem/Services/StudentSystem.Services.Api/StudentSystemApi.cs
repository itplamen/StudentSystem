namespace StudentSystem.Services.Api
{
    using System;
    using System.Threading.Tasks;

    using StudentSystem.Services.Api.Contracts;

    public class StudentSystemApi : IStudentSystemApi
    {
        public async Task<TResponse> Execute<TResponse>(Func<Task<TResponse>> request)
        {
            TResponse response = await request();

            return response;
        }

        public async Task<TResponse> Execute<TRequest, TResponse>(Func<TRequest, Task<TResponse>> request, TRequest model)
        {
            TResponse response = await request(model);

            return response;
        }

        public async Task<TResponse> Execute<TRequest, TResponse>(Func<int, TRequest, Task<TResponse>> request, int id, TRequest model)
        {
            TResponse response = await request(id, model);

            return response;
        }
    }
}