namespace Decorator
{
    public class CarDataProviderMemoryCacheDecorator : ICarDataProvider
    {
        private readonly ICarDataProvider _carDataProvider;
        private readonly CarCacheController _carCacheController;

        public CarDataProviderMemoryCacheDecorator(ICarDataProvider carDataProvider, CarCacheController carCacheController)
        {
            _carDataProvider = carDataProvider;
            _carCacheController = carCacheController;
        }
        
        public CarModel GetData()
        {
            var carModel = _carDataProvider.GetData();
            _carCacheController.Add(carModel);

            return carModel;
        }
    }
}