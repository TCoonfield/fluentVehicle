using System;

namespace FluentTestThingy
{
    public class CarBuilder
    {
        private EngineBuilder<CarBuilder> engineBuilder;

        private string Make;
        private string Model;
        private int Doors;
        private int Year;

        public EngineBuilder<CarBuilder> HasEngine()
        {
            this.engineBuilder = new EngineBuilder<CarBuilder>(this);

            return engineBuilder;
        }

        public CarBuilder WithDoors(int doors)
        {
            Doors = doors;
            return this;
        }

        public CarBuilder MakeIs(string make)
        {
            Make = make;
            return this;
        }

        public CarBuilder ModelIs(string model)
        {
            Model = model;
            return this;
        }

        public CarBuilder YearIs(int year)
        {
            Year = year;
            return this;
        }

        public static implicit operator Car(CarBuilder builder)
        {
            return new Car(builder.engineBuilder, builder.Doors, builder.Make, builder.Model, builder.Year);
        }

    }
}