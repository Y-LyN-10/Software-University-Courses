using System;
using System.Net.Configuration;
using System.Text;

namespace LaptopShop
{
    public class Laptop
    {
        private string _model;
        private double _screenSize;
        private decimal _price;

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

        public Laptop(string model, string manufacturer, string processor, string graphicsCard, string batteryDescription)
            : this(model, manufacturer, processor, graphicsCard, batteryDescription, 0, 0, 0)
        {
        }

        public Laptop(string model, decimal price)
            : this(model, null, null, null, null, 0, 0, price)
        {
        }

        /* Only model and price are mandatory, so other values can be null 
           or empty and there is no need to validate this everywhere */

        public string Model
        {
            get { return this._model; }
            private set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException();
                    }
                    this._model = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Model name can't be null or empty", ex);
                    throw;
                }
            }
        }

        public string Manufacturer { get; private set; }

        public string Processor { get; private set; }

        public string GraphicsCard { get; private set; }

        public double ScreenSize
        {
            get { return this._screenSize; }
            private set
            {
                try
                {
                    if (_screenSize < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    this._screenSize = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Screen size can't be a negative number", ex);
                    throw;
                }
            }
        }

        public decimal Price
        {
            get { return this._price; }
            private set
            {
                try
                {
                    if (_price < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    this._price = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Price can't be a negative number", ex);
                    throw;
                }
            }
        }

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
