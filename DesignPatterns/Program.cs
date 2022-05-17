using System.Collections;
using System.Collections.Generic;
using Adapter;
using Decorator;
using Facade;
using FactoryMethod.Example1;
using TemplateMethod.Example1;
using SingletonPattern;

namespace DesignPatterns
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      #region TemplateMethod

      University university = new University();
      School school = new School();
      
      university.Learn();
      school.Learn();
      
      #endregion

      #region Adapter

      ILogReader logReader = new LogFileReader();
      IList<LogEntry> logs = logReader.Read();
      SqlServerLogSaver sqlServerLogSaver = new SqlServerLogSaver();

      var firstLog = logs[0];

      sqlServerLogSaver.Save(firstLog.DataTime, firstLog.Severity, firstLog.Message);
      sqlServerLogSaver.Save(firstLog);

      FirebaseLogSaver firebaseLogSaver = new FirebaseLogSaver();
      ILogSaver adapter = new FirebaseLogSaverAdapter(firebaseLogSaver);
      adapter.Save(firstLog.DataTime, firstLog.Severity, firstLog.Message);

      #endregion

      #region FactoryMethod

      CarInfoStorage carInfoStorage = new CarInfoStorage(new List<CarFactory>
        { new AudiFactory(), new BmwFactory(), new VolkswagenFactory() });
      carInfoStorage.Save();

      #endregion
      
      #region Facade

      var clientController = new ClientController();
      var bankController = new BankController();
      var transactionController = new TransactionControllerFacade(bankController, clientController);
      transactionController.TransferMoney(1000);
      
      #endregion

      #region Decorator

      ICarDataProvider carDataProvider = new CarDataProvider();
      CarCacheController cashController = new CarCacheController();
      ICarDataProvider carDataProviderWithXmlCache = new CarDataProviderXmlCacheDecorator(carDataProvider);
      ICarDataProvider carDataProviderWithMemoryCache = new CarDataProviderMemoryCacheDecorator(carDataProviderWithXmlCache, cashController);
      
      carDataProviderWithMemoryCache.GetData();

      #endregion

      #region Singleton

      var instance = Singleton.Instance;
      
      instance.Foo();

      #endregion
    }
  }
}