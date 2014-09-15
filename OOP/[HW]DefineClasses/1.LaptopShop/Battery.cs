using System;

namespace _1.LaptopShop
{
    public class Battery
    {
        public Battery(string description, int lifeInHours) 
        {
            this.Description = description;
            this.LifeInHours = lifeInHours;
        }

        public int LifeInHours { get; private set; }
        public string Description {get; private set;}

        //TODO: override ToString() here
        //TODO: Add Validations
    }
}
