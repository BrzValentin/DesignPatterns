namespace FactoryMethod.Example1
{
    public class AudiFactory : CarFactory
    {
        public override Car Create()
        {
            return new Audi();
        }
    }
}