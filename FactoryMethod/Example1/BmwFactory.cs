namespace FactoryMethod.Example1
{
    public class BmwFactory : CarFactory
    {
        public override Car Create()
        {
            return new Bmw();
        }
    }
}