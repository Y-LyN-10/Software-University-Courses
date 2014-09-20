using System;

namespace LaptopShop.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class LaptopTests
    {
        [TestMethod]
        public void CreatingLaptopWithValidDataShouldSetAllPropertiesCorrectly()
        {
            var laptop = new Laptop(
                "VN7-591G", // Model
                "Acer Aspire", // Manufacturer
                "Intel Core i7-4710HQ", // Processor
                "NVIDIA GeForce GTX 860M", // Graphics card
                "8 cells", // Battery
                4, // Battery life in hours
                15.6, // Screen size
                1959 // Price in leva
            );

            Assert.AreEqual("Acer Aspire", laptop.Manufacturer, "Manufacturer name is set wrong");
            Assert.AreEqual("VN7-591G", laptop.Model, "Model name is set wrong");
            Assert.AreEqual("Intel Core i7-4710HQ", laptop.Processor, "Processor name is set wrong");
            Assert.AreEqual("NVIDIA GeForce GTX 860M", laptop.GraphicsCard, "Graphics card name is set wrong");
            Assert.AreEqual("8 cells", laptop.Battery.Description, "Battery description is set wrong");
            Assert.AreEqual(4, laptop.Battery.LifeInHours, "Battery life in hours description is set wrong");
            Assert.AreEqual(15.6, laptop.ScreenSize, "Screen size is set wrong");
            Assert.AreEqual(1959, laptop.Price, "Price is set wrong");
        }

        [TestMethod]
        public void ScreenSizeShouldBeZeroWhenNotSet()
        {
            var laptop = new Laptop("VN7-591G", "Acer Aspire", "Intel Core i7-4710HQ",
                "NVIDIA GeForce GTX 860M", "8 cells");

            Assert.AreEqual(0, laptop.ScreenSize);
        }

        [TestMethod]
        public void PriceShouldBeZeroWhenNotSet()
        {
            var laptop = new Laptop("VN7-591G", "Acer Aspire", "Intel Core i7-4710HQ",
                "NVIDIA GeForce GTX 860M", "8 cells");

            Assert.AreEqual(0, laptop.Price);
        }

        [TestMethod]
        public void ToStringMethodShouldFormatPropertiesCorrectly()
        {
            var laptop = new Laptop("VN7-591G", "Acer Aspire", "Intel Core i7-4710HQ",
                "NVIDIA GeForce GTX 860M", "8 cells", 4, 15.6, 1959);

            var result = laptop.ToString();

            var expected = string.Format("Laptop: Acer Aspire VN7-591G{0}Processor: Intel Core i7-4710HQ{0}Graphics card: NVIDIA GeForce GTX 860M{0}Screen size: 15,6 inches{0}Price: 1959 lv{0}Battery: 8 cells (4 hours)", Environment.NewLine);
            Assert.AreEqual(result, expected, "Wrong ToString() formatting");
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentOutOfRangeException))]
        //public void SettingEmptyManufacturerNameShouldThrowException()
        //{
        //    var laptop = new Laptop("VN7-591G", "", "Intel Core i7-4710HQ",
        //        "NVIDIA GeForce GTX 860M", "8 cells", 4, 15.6, 1959);

        //    Console.WriteLine(laptop.Manufacturer);
        //}
    }
}
