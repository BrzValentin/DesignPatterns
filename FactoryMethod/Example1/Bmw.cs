namespace FactoryMethod.Example1
{
    public class Bmw : Car
    {
        public override string Model { get; } = "Bmw";
        public override int MaxVelocity { get; } = 250;
    }
}