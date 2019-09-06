namespace StudentSystem.Services.Api.Contracts
{
    using System;
    using System.Threading.Tasks;

    public interface IStudentSystemApi
    {
        Task<TResponse> Execute<TResponse>(Func<Task<TResponse>> request);

        Task<TResponse> Execute<TRequest, TResponse>(Func<TRequest, Task<TResponse>> request, TRequest model);

        Task<TResponse> Execute<TRequest, TResponse>(Func<int, TRequest, Task<TResponse>> request, int id, TRequest model);
    }
}