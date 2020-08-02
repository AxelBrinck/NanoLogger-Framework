using System;
using Nanologger.Entities;
using Nanologger.Enums;

namespace Nanologger.Format
{
    /// <summary>
    /// Sets a default format to be used in a stream based output logging.
    /// </summary>
    public class DefaultFormat : IFormat
    {
        /// <summary>
        /// Returns a formatted string with a given logging information object.
        /// </summary>
        /// <param name="logInfo">The required logging information object.</param>
        /// <returns>The formatted string.</returns>
        public string Format(Log logInfo)
        {
            return $"[{Enum.GetName(typeof(Severity), logInfo.Severity), -12}] - {logInfo.Timestamp.ToLongTimeString()} - {logInfo.Source}: '{logInfo.Message}'";
        }
    }
}