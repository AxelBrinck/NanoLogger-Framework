using Nanologger.Entities;

namespace Nanologger.Output
{
    /// <summary>
    /// This interface provides abstraction about the storage procedure.
    /// For example: It is not the same procedure to store in a file, or in a database.
    /// Implement this database to write the storage code for your target platform.
    /// </summary>
    public interface ILogOutput
    {
        /// <summary>
        /// Executes the storage procedure to save a given logging information object.
        /// </summary>
        /// <param name="logInfo">The logging information object.</param>
        void Store(LogInfo logInfo);
    }
}