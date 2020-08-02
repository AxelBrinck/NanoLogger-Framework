using LoggingFramework.Entities;

namespace LoggingFramework.Output
{
    public interface ILogOutput
    {
        void Store(LogInfo logInfo);
    }
}