namespace Adapter
{
    public class SqlServerLogSaver : ILogSaver
    {
        //connection
        
        public void Save(string dataTime, string severity, string message)
        {
            //save
        }
        
        public void Save(LogEntry logEntry)
        {
            //save
        }
    }
}