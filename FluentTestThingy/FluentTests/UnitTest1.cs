using FluentTestThingy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FluentTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void CarShouldHaveAnEngineFluently()
        {
            Car car = new CarBuilder().HasEngine().WithCylinders(8).WithHorsePower(400).WithTurbo().And.WithDoors(4);

            Assert.AreEqual(car.Engine.Cylinders, 8);
            Assert.IsTrue(car.Engine.HasTurbo);
            Assert.AreEqual(car.Engine.HorsePower, 400);
            Assert.AreEqual(car.Doors, 4);
        }

        [TestMethod]
        public void MotorCycleShouldHaveEngingAndPropertiesFluently()
        {
            MotorCycle bike = new MotorCycleBuilder().HasEngine().WithCylinders(2).WithHorsePower(110).And.IsMake("Buell").IsModel("Cyclone");

            Assert.AreEqual(bike.Engine.Cylinders, 2);
            Assert.AreEqual(bike.Engine.HasTurbo, false);
            Assert.AreEqual(bike.Engine.HorsePower, 110);
            Assert.AreEqual(bike.Make, "Buell");
            Assert.AreEqual(bike.Model, "Cyclone");
        }
    }
}
