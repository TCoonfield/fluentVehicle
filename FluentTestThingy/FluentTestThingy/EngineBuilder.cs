using System.Collections.Concurrent;

namespace FluentTestThingy
{
    public class EngineBuilder<T>
    {
        private int Cylinders;
        private int HorsePower;
        private bool HasTurbo;

        private readonly T parent;

        public EngineBuilder(T parent)
        {
            this.parent = parent;
        }

        public EngineBuilder<T> WithCylinders(int cylinders)
        {
            Cylinders = cylinders;
            return this;
        }

        public EngineBuilder<T> WithHorsePower(int hp)
        {
            HorsePower = hp;
            return this;
        }

        public EngineBuilder<T> WithTurbo()
        {
            HasTurbo = true;
            return this;
        }

        public T And { get { return parent; } }

        public static implicit operator Engine(EngineBuilder<T> builder)
        {
            return new Engine(builder.Cylinders, builder.HorsePower, builder.HasTurbo);
        }
    }
}