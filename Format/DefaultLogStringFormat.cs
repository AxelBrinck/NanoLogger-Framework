using System;
using Nanologger.Entities;
using Nanologger.Enums;

namespace Nanologger.Format
{
    public class DefaultLogStringFormat : ILogStringFormat
    {
        public string Format(LogInfo logInfo)
        {
            return $"[{Enum.GetName(typeof(Severity), logInfo.Severity), -12}] - {logInfo.Time.ToLongTimeString()} - {logInfo.Source}: '{logInfo.Message}'";
        }
    }
}