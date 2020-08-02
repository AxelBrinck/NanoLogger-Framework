using System;
using Nanologger.Enums;

namespace Nanologger.Entities
{
    
    /// <summary>
    /// Represents a log.
    /// </summary>
    public class Log
    {
        /// <summary>
        /// The severity of the log.
        /// </summary>
        /// <value>Gets the value of the severity</value>
        public Severity Severity { get; }

        /// <summary>
        /// The timestamp of the log. The time when this log was generated.
        /// </summary>
        /// <value>Gets the value of the timestamp</value>
        public DateTime Timestamp { get; }

        /// <summary>
        /// The source module where the log was created. Ex: Main, Ex: Some process...
        /// </summary>
        /// <value>Gets the value of the source.</value>
        public string Source { get; }

        /// <summary>
        /// The message, description, details of the log.
        /// </summary>
        /// <value>Gets the message.</value>
        public string Message { get; }
        
        /// <summary>
        /// Creates a log object.
        /// This object cannot be modified later, as its properties are read-only.
        /// </summary>
        /// <param name="severity">Sets the severity of the log.</param>
        /// <param name="timestamp">Sets the timestamp of the log.</param>
        /// <param name="source">Sets the source of the log.</param>
        /// <param name="message">Sets the message of the log.</param>
        public Log(Severity severity, DateTime timestamp, string source, string message)
        {
            Severity = severity;
            Timestamp = timestamp;
            Source = source;
            Message = message;
        }
    }
}