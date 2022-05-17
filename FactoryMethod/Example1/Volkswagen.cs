namespace FactoryMethod.Example1
{
    public class Volkswagen : Car
    {
        public override string Model { get; } = "Volkswagen";

        public override int MaxVelocity { get; } = 230;
    }
}