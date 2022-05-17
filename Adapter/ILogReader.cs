using System.Collections.Generic;

namespace Adapter
{
    public interface ILogReader
    {
        IList<LogEntry> Read();
    }
}