using System;
using System.Globalization;
using System.Text;

namespace PCCatalog
{
    public class Component
    {
        private string _name;
        private decimal _price;

        public Component(string name, string details, decimal price)
        {
            this.Name = name;
            this.Details = details;
            this.Price = price;
        }

        public Component(string name, decimal price) : this(name, null, price)
        {
        }

        public string Name
        {
            get { return this._name; }
            private set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException();
                    }
                    if (value.Length < 2 || value.Length > 20)
                    {
                        throw new ArgumentOutOfRangeException();
                    }

                    this._name = value;
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine("Name can't be null or empty", ex);
                    throw;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine("Name should have at least 2 letters and can't be more than 20 letters", ex);
                    throw;
                }
            }
        }

        public string Details { get; private set; }

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

        public override string ToString()
        {
            var sb = new StringBuilder();
            var bgPrice = this.Price.ToString("C2", CultureInfo.CreateSpecificCulture("bg-BG"));

            sb.AppendFormat("[{0}] {1} ({2})", this.Name, this.Details, bgPrice);

            return sb.ToString();
        }
    }
}
