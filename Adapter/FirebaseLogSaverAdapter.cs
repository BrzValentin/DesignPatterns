namespace Adapter
{
    public class FirebaseLogSaverAdapter : ILogSaver
    {
        private readonly FirebaseLogSaver _firebaseLogSaver;

        public FirebaseLogSaverAdapter(FirebaseLogSaver firebaseLogSaver)
        {
            _firebaseLogSaver = firebaseLogSaver;
        }
        
        public void Save(string dataTime, string severity, string message)
        {
            bool isExc = severity == "FATAL";
            SimpleLogEntry logEntry = new SimpleLogEntry { IsException = isExc, Message = message};
            _firebaseLogSaver.Save(logEntry);
        }

        public void Save(LogEntry entry)
        {
            bool isExc = entry.Severity == "FATAL";
            SimpleLogEntry logEntry = new SimpleLogEntry { IsException = isExc, Message = entry.Message};
            _firebaseLogSaver.Save(logEntry);
        }
    }
}