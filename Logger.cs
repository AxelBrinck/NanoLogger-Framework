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
        private readonly List<IOutput> _destinations = new List<IOutput>();

        /// <summary>
        /// Adds an output to the logger object.
        /// </summary>
        /// <param name="output">The given output procedure to be stored in the list.</param>
        public void AddOutput(IOutput output) => _destinations.Add(output);

        /// <summary>
        /// The main mthod to log.
        /// </summary>
        /// <param name="log">The given logging information.</param>
        public void Log(Log log)
        {
            if (_destinations.Count == 0)
            {
                throw new InvalidOperationException("There is no output specified to log.");
            }
            
            foreach (var destination in _destinations)
            {
                destination.Store(log);
            }
        }
    }
}