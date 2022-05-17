using System.IO;
using System.Xml.Serialization;

namespace Decorator
{
    public class CarDataProviderXmlCacheDecorator : ICarDataProvider
    {
        private readonly ICarDataProvider _carDataProvider;

        public CarDataProviderXmlCacheDecorator(ICarDataProvider carDataProvider)
        {
            _carDataProvider = carDataProvider;
        }
        
        public CarModel GetData()
        {
            var carModel = _carDataProvider.GetData();
            
            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(CarModel));
                writer = new StreamWriter("C:\\Users\\vberezin\\RiderProjects\\DesignPatterns\\Decorator\\CarData.xml", false);
                serializer.Serialize(writer, carModel);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }

            return carModel;
        }
    }
}