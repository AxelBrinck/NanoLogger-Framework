using Nanologger.Entities;

namespace Nanologger.Format
{
    public interface ILogStringFormat
    {
        string Format(LogInfo logInfo);
    }
}