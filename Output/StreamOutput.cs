using System.IO;
using Nanologger.Entities;
using Nanologger.Format;

namespace Nanologger.Output
{
    /// <summary>
    /// Defines a stream-based logging output.
    /// Streams can target files, network, and all stream-based procedures.
    /// </summary>
    public class StreamOutput : IOutput
    {
        private readonly StreamWriter _writer;
        private readonly IFormat _format;
        
        /// <summary>
        /// Instantiates the object by given a stream and a format.
        /// </summary>
        /// <param name="stream">The given stream to write to.</param>
        /// <param name="format">The given format to represent the logging objects over a stream.</param>
        public StreamOutput(Stream stream, IFormat format)
        {
            _writer = new StreamWriter(stream);
            _format = format;
        }
        
        /// <summary>
        /// The method used to format and push over a stream a given logging information.
        /// </summary>
        /// <param name="logInfo">The given logging information to store.</param>
        public void Store(Log logInfo)
        {
            var formattedLog = _format.Format(logInfo);
            
            _writer.WriteLine(formattedLog);
            
            _writer.Flush();
        }
    }
}