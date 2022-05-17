using System.Collections.Generic;

namespace Decorator
{
    public class CarCacheController
    {
        private IDictionary<string, CarModel> _carModelById = new Dictionary<string, CarModel>();

        public void Add(CarModel model)
        {
            _carModelById.Add(model.Id, model);
        }

        public bool TryGet(string id, out CarModel carModel)
        {
            return _carModelById.TryGetValue(id, out carModel);
        }

        public CarModel Get(string id)
        {
            return _carModelById[id];
        }
    }
}