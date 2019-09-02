namespace StudentSystem.Services.Api
{
    using System;
    using System.Text;
    using System.Threading.Tasks;

    using Newtonsoft.Json;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Services.Api.Contracts;

    public class RequestsExecutorLoggingDecorator : IRequestsExecutor
    {
        private const string LOGGER = "RequestsExecutor";

        private readonly ILogger logger;
        private readonly IRequestsExecutor requestsExecutor;

        public RequestsExecutorLoggingDecorator(ILoggerFactory loggerFactory, IRequestsExecutor requestsExecutor)
        {
            this.requestsExecutor = requestsExecutor;
            this.logger = loggerFactory.Create(LOGGER, LOGGER);
        }

        public async Task<TResponse> Execute<TResponse>(Func<Task<TResponse>> request)
        {
            try
            {
                TResponse response = await requestsExecutor.Execute(request);
                Log($"{nameof(request)} - {ToJson(request)}", response);

                return response;
            }
            catch (Exception ex)
            {
                logger.LogError($"Request to {nameof(request)} failed", ex);

                return await Task.FromResult(default(TResponse));
            }
        }

        public async Task<TResponse> Execute<TRequest, TResponse>(Func<TRequest, Task<TResponse>> request, TRequest model)
        {
            try
            {
                TResponse response = await requestsExecutor.Execute(request, model);
                Log($"{nameof(request)} - {ToJson(request)}", response);

                return response;
            }
            catch (Exception ex)
            {
                logger.LogError($"Request to {nameof(request)} failed", ex);

                return await Task.FromResult(default(TResponse));
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