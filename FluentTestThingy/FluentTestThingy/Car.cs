namespace FluentTestThingy
{
    public class Car
    {
        public Car(Engine engine, int doors, string make, string model, int year)
        {
            Engine = engine;
            Doors = doors;
            Make = make;
            Model = model;
            Year = year;
        }

        public Engine Engine { get; private set; }
        public int Doors { get; private set; }
        public string Make { get; private set; }
        public string Model { get; private set; }
        public int Year { get; private set; }

    }
}