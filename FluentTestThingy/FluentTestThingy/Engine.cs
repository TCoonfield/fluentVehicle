namespace FluentTestThingy
{
    public class Engine
    {
        public Engine(int cylinders, int horsePower, bool hasTurbo)
        {
            Cylinders = cylinders;
            HorsePower = horsePower;
            HasTurbo = hasTurbo;
        }

        public int Cylinders { get; private set; }
        public int HorsePower { get; private set; }
        public bool HasTurbo { get; private set; }
    }
}