namespace StudentSystem.Services.Api.Contracts
{
    using System;
    using System.Threading.Tasks;

    public interface IRequestsExecutor
    {
        Task<TResponse> Execute<TResponse>(Func<Task<TResponse>> request);

        Task<TResponse> Execute<TRequest, TResponse>(Func<TRequest, Task<TResponse>> request, TRequest model);
    }
}