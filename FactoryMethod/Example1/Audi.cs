namespace FactoryMethod.Example1
{
    public class Audi : Car
    {
        public override string Model { get; } = "Audi";
        public override int MaxVelocity { get; } = 240;
    }
}