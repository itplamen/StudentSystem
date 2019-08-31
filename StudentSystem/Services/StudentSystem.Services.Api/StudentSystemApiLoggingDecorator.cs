namespace StudentSystem.Services.Api
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Services.Api.Contracts;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public class StudentSystemApiLoggingDecorator : IStudentSystemApi
    {
        private const string LOGGER = "StudentSystemApi";

        private readonly ILogger logger;
        private readonly IStudentSystemApi decorated;

        public StudentSystemApiLoggingDecorator(IStudentSystemApi decorated, ILoggerFactory loggerFactory)
        {
            this.decorated = decorated;
            this.logger = loggerFactory.Create(LOGGER, LOGGER);
        }

        public async Task<IEnumerable<SemesterResponseModel>> GetStudentDetailsAsync()
        {
            try
            {
                IEnumerable<SemesterResponseModel> response = await decorated.GetStudentDetailsAsync();

                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.AppendLine($"Request: {nameof(GetStudentDetailsAsync)}");
                stringBuilder.AppendLine($"Response: {ToJson(response)}");

                logger.LogInfo(stringBuilder.ToString());

                return response;
            }
            catch (Exception ex)
            {
                logger.LogError($"Request to {nameof(GetStudentDetailsAsync)} failed", ex);

                return await Task.FromResult(Enumerable.Empty<SemesterResponseModel>());
            }
        }

        private string ToJson<T>(T model) 
            where T : class
        {
            try
            {
                return JsonConvert.SerializeObject(model);
            }
            catch (Exception ex)
            {
                string type = model.GetType().ToString();
                logger.LogError($"Could not serialize model{type}", ex);

                return type;
            }
        }
    }
}