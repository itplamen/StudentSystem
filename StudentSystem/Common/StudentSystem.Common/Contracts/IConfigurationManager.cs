namespace StudentSystem.Common.Contracts
{
    public interface IConfigurationManager
    {
        string ConnectionString { get; }

        string Get(string key);
    }
}