using System.Collections.Generic;

namespace FactoryMethod.Example1
{
    public class CarInfoStorage
    {
        private readonly IList<CarFactory> _factories;

        private readonly IList<int> _maxVelocities = new List<int>();

        public CarInfoStorage(IList<CarFactory> factories)
        {
            _factories = factories;
        }

        public void Save()
        {
            foreach (var factory in _factories)
            {
                Car car = factory.Create();
                _maxVelocities.Add(car.MaxVelocity);
            }
        }
    }
}