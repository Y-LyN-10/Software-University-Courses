using System;
using System.Net.Configuration;
using System.Text;

namespace LaptopShop
{
    public class Laptop
    {
        public Laptop(string model, string manufacturer, string processor,
            string graphicsCard, string batteryDescription, double batteryLifeInHours, double screenSize, decimal price)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.GraphicsCard = graphicsCard;
            this.Battery = new Battery(batteryDescription, batteryLifeInHours);
            this.ScreenSize = screenSize;
            this.Price = price;
        }

        public Laptop(string model, string manufacturer, string processor,
            string graphicsCard, string batteryDescription)
            : this(model, manufacturer, processor, graphicsCard, batteryDescription, 0, 0, 0)
        {
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

            sb.AppendFormat("Laptop: {1} {2}{0}Processor: {3}{0}Graphics card: {4}{0}Screen size: {5} inches{0}Price: {6} lv{0}Battery: {7}", 
                Environment.NewLine, this.Manufacturer, this.Model, this.Processor, this.GraphicsCard, this.ScreenSize, this.Price, this.Battery);

            return sb.ToString();
        }

        //TODO: Add Validations
    }
}
