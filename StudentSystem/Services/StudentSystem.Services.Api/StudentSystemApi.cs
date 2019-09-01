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

    public class StudentSystemApi : IStudentSystemApi
    {
        private const string LOGGER = "StudentSystemApi";

        private readonly ILogger logger;
        private readonly StudentsServiceClient studentsService;

        public StudentSystemApi(ILoggerFactory loggerFactory, StudentsServiceClient studentsService)
        {
            this.studentsService = studentsService;
            this.logger = loggerFactory.Create(LOGGER, LOGGER);
        }

        public async Task<IEnumerable<SemesterResponseModel>> GetStudentDetailsAsync()
        {
            try
            {
                IEnumerable<SemesterResponseModel> response = await studentsService.GetAsync();
                Log(nameof(GetStudentDetailsAsync), response);

                return response;
            }
            catch (Exception ex)
            {
                logger.LogError($"Request to {nameof(GetStudentDetailsAsync)} failed", ex);

                return await Task.FromResult(Enumerable.Empty<SemesterResponseModel>());
            }
        }

        private void Log<TModel>(string request, TModel response)
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Request: {request}");
            stringBuilder.AppendLine($"Response: {ToJson(response)}");

            logger.LogInfo(stringBuilder.ToString());
        }

        private string ToJson<TModel>(TModel model)
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