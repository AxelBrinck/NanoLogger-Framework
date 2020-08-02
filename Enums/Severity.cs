namespace Nanologger.Enums
{
    
    /// <summary>
    /// Enumerates all the valid severities.
    /// </summary>
    public enum Severity
    {
        /// System unusable.
        Emergency,

        /// Immediate action needed.
        Alert,

        /// Critical condition.
        Critical,

        /// Error condition.
        Error,

        /// Warning condition.
        Warning,

        /// Normal but significant condition.
        Notice,

        /// Informational message only.
        Information,

        /// Behaviour details.
        Debug
    }
}