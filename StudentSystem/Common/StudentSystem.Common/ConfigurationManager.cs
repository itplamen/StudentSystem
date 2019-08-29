namespace StudentSystem.Common
{
    using System;

    using StudentSystem.Common.Contracts;
    
    public class ConfigurationManager : IConfigurationManager
    {
        public string ConnectionString => System.Configuration.ConfigurationManager
            .ConnectionStrings["DefaultConnection"].ConnectionString;

        public string Get(string key)
        {
            string configuration = System.Configuration.ConfigurationManager.AppSettings[key];

            if (string.IsNullOrEmpty(configuration))
            {
                throw new InvalidOperationException($"Could not find configuration {key}!");
            }

            return configuration;
        }
    }
}