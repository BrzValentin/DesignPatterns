using System.Collections.Generic;

namespace Adapter
{
    public class LogFileReader : ILogReader
    {
        public IList<LogEntry> Read()
        {
            var logEntry = new LogEntry
            {
                DataTime = "15.02.2002", Severity = "INFO",
                Message = "XLog.LogManager|>>> LogManager initialized successfully. UTC time: Wed, 15 Sep 2021 12:18:13 GMT"
            };
            
            var list = new List<LogEntry>();
            list.Add(logEntry);

            return list;
        }
    }
}