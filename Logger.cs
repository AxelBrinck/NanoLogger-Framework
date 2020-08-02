﻿using System;
using System.Collections.Generic;
using LoggingFramework.Entities;
using LoggingFramework.Output;

namespace LoggingFramework
{
    public class Logger
    {
        private readonly List<ILogOutput> _destinations = new List<ILogOutput>();

        public void AddOutput(ILogOutput logOutput) => _destinations.Add(logOutput);

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