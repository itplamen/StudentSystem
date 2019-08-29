namespace StudentSystem.Services.Api
{
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using StudentSystem.Services.Api.Contracts;

    public class StudentSystemApi : IStudentSystemApi
    {
        private const string DEFAULT_MEDIA_TYPE_HEADER = "application/json";

        private readonly HttpClient httpClient;

        public StudentSystemApi(HttpClient httpClient)
        {
            this.httpClient = httpClient;
            this.httpClient.DefaultRequestHeaders.Add("Connection", "close");
            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(DEFAULT_MEDIA_TYPE_HEADER));
        }

        public async Task<T> GetAsync<T>(string url)
            where T : class
        {
            HttpResponseMessage responseMessage = await this.httpClient.GetAsync(url);
            string jsonString = await responseMessage.Content.ReadAsStringAsync();
            T response = JsonConvert.DeserializeObject<T>(jsonString);

            return response;
        }
    }
}