namespace FactoryMethod.Example1
{
    public class VolkswagenFactory : CarFactory
    {
        public override Car Create()
        {
            return new Volkswagen();
        }
    }
}