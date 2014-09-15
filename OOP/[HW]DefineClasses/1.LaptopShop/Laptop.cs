using System;
using System.Text;

namespace _1.LaptopShop
{
    public class Laptop
    {
        public Laptop(string model, string manufacturer, string processor,
            string graphicsCard, Battery battery, double screenSize, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.GraphicsCard = graphicsCard;
            this.Battery = battery; // new Battery(desctiption, lifeInHours)
            this.ScreenSize = screenSize;
            this.Price = price;
        }

        public string Model { get; private set; }

        public string Manufacturer { get; private set; }

        public string Processor { get; private set; }

        public string GraphicsCard { get; private set; }

        public double ScreenSize { get; private set; }

        public decimal Price { get; private set; }

        public Battery Battery { get; private set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Laptop: {0} {1}\nProcessor: {2}\nGraphics card: {3}\n",
                this.Manufacturer, this.Model, this.Processor, this.GraphicsCard);
            sb.AppendFormat("Screen size: {0} inches\nPrice: {1} lv\nBattery: {2}\nBattery life: {3} hours",
                this.ScreenSize, this.Price, this.Battery.Description, this.Battery.LifeInHours);

            return sb.ToString();
      }

        //TODO: Add Validations
    }
}
