using System;
using System.Collections.Generic;
using Nanologger.Entities;
using Nanologger.Output;

namespace Nanologger
{
    /// <summary>
    /// The main logger object.
    /// </summary>
    public class Logger
    {
        /// <summary>
        /// The list of outputs that the logger will have.
        /// You can have multiple outputs at the same time.
        /// </summary>
        private readonly List<ILogOutput> _destinations = new List<ILogOutput>();

        /// <summary>
        /// Adds an output to the logger object.
        /// </summary>
        /// <param name="logOutput">The given output procedure to be stored in the list.</param>
        public void AddOutput(ILogOutput logOutput) => _destinations.Add(logOutput);

        /// <summary>
        /// The main mthod to log.
        /// </summary>
        /// <param name="logInfo">The given logging information.</param>
        public void Log(LogInfo logInfo)
        {
            if (_destinations.Count == 0)
            {
                throw new InvalidOperationException("There is no output specified to log.");
            }
            
            foreach (var destination in _destinations)
            {
                destination.Store(logInfo);
            }
        }
    }
}