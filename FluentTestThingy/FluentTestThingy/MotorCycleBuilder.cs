using System.Runtime.CompilerServices;

namespace FluentTestThingy
{
    public class MotorCycleBuilder
    {
        private string make;
        private string model;
        private EngineBuilder<MotorCycleBuilder> engine;
        private int year;

        public MotorCycleBuilder IsMake(string make)
        {
            this.make = make;
            return this;
        }

        public MotorCycleBuilder IsModel(string model)
        {
            this.model = model;
            return this;
        }

        public EngineBuilder<MotorCycleBuilder> HasEngine()
        {
            this.engine = new EngineBuilder<MotorCycleBuilder>(this);
            return engine;
        }

        public static implicit operator MotorCycle(MotorCycleBuilder builder)
        {
            return new MotorCycle(builder.engine, builder.make, builder.model, builder.year);
        }
    }
}