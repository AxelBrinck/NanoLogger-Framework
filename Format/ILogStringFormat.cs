using LoggingFramework.Entities;

namespace LoggingFramework.Format
{
    public interface ILogStringFormat
    {
        string Format(LogInfo logInfo);
    }
}