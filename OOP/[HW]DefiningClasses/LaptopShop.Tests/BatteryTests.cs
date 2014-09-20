using System;

namespace LaptopShop.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class BatteryTests
    {
        [TestMethod]
        public void CreatingBatterytWithValidDataShouldSetAllPropertiesCorrectly()
        {
            var battery = new Battery("8 cells", 4.5);

            Assert.AreEqual("8 cells", battery.Description, "Battery description name is set wrong");
            Assert.AreEqual(4.5, battery.LifeInHours, "Battery life in hours description is set wrong");
        }

        [TestMethod]
        public void BatteryLifeInHoursShouldBeZeroWhenNotSet()
        {
            var battery = new Battery("8 cells");

            Assert.AreEqual(0, battery.LifeInHours);
        }
    }
}
