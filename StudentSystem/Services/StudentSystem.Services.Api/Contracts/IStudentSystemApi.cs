namespace StudentSystem.Services.Api.Contracts
{
    using System.Threading.Tasks;

    public interface IStudentSystemApi
    {
        Task<T> GetAsync<T>(string url)
            where T : class;
    }
}