using System;

namespace LaptopShop
{
    public class Battery
    {
        public Battery(string description, double lifeInHours)
        {
            this.Description = description;
            this.LifeInHours = lifeInHours;
        }

        public Battery(string description) : this(description, 0)
        {
        }

        public double LifeInHours { get; private set; }
        public string Description { get; private set; }

        public override string ToString()
        {
            return String.Format("{0} ({1} hours)", this.Description, this.LifeInHours);
        }

        //TODO: Add Validations
    }
}
