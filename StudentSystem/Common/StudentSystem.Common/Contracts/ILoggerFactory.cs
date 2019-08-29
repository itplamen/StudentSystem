namespace StudentSystem.Common.Contracts
{
    public interface ILoggerFactory
    {
        ILogger Create(string file, string directory);
    }
}