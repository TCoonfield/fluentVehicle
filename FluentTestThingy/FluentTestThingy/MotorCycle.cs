namespace FluentTestThingy
{
    public class MotorCycle
    {
        public MotorCycle(Engine engine, string make, string model, int year)
        {
            Engine = engine;
            Make = make;
            Model = model;
            Year = year;
        }

        public Engine Engine { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
}