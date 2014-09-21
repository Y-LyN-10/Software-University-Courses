using System;

namespace LaptopShop
{
    public class Battery
    {
        private double _lifeInHours;

        public Battery(string description, double lifeInHours)
        {
            this.Description = description;
            this.LifeInHours = lifeInHours;
        }

        public Battery(string description)
            : this(description, 0)
        {
        }

        public double LifeInHours
        {
            get { return this._lifeInHours; }
            private set
            {
                try
                {
                    if (_lifeInHours < 0)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    this._lifeInHours = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Battery life in hours can't be a negative number", ex);
                    throw;
                }
            }
        }

        public string Description { get; private set; }

        public override string ToString()
        {
            return String.Format("{0} ({1} hours)", this.Description, this.LifeInHours);
        }
    }
}
