using System;
using LoggingFramework.Enums;

namespace LoggingFramework.Entities
{
    
    /**
     * Responsibility: To represent a log.
     * Can also be called 'Log',
     *     but I decided to go with LogInfo to know more about the object by just the reading the name.
     */
    public class LogInfo
    {
        public Severity Severity { get; }
        public DateTime Time { get; }
        public string Source { get; }
        public string Message { get; }
        
        public LogInfo(Severity severity, DateTime time, string source, string message)
        {
            Severity = severity;
            Time = time;
            Source = source;
            Message = message;
        }
    }
}