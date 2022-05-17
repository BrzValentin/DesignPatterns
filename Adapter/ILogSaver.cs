namespace Adapter
{
    public interface ILogSaver
    {
        void Save(string dataTime, string severity, string message);

        void Save(LogEntry entry);
    }
}