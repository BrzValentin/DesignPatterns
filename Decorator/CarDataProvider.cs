namespace Decorator
{
    public class CarDataProvider : ICarDataProvider
    {
        public CarModel GetData()
        {
            return new CarModel { Id = "sdfsdf", Model = "BMW" };
        }
    }
}