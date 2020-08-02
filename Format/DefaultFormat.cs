using System;
using Nanologger.Entities;
using Nanologger.Enums;

namespace Nanologger.Format
{
    /// <summary>
    /// Defines a default format to represent logs over a string.
    /// </summary>
    public class DefaultFormat : IFormat
    {
        /// <summary>
        /// Returns a formatted string with a given logging information object.
        /// </summary>
        /// <param name="log">The required logging information object.</param>
        /// <returns>The formatted string.</returns>
        public string Format(Log log)
        {
            return $"[{Enum.GetName(typeof(Severity), log.Severity), -12}] - {log.Timestamp.ToLongTimeString()} - {log.Source}: '{log.Message}'";
        }
    }
}