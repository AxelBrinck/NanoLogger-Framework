using Nanologger.Entities;

namespace Nanologger.Output
{
    public interface ILogOutput
    {
        void Store(LogInfo logInfo);
    }
}