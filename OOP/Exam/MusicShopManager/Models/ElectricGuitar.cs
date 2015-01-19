using System;
using System.Text;
using MusicShopManager.Interfaces;

namespace MusicShop.Models
{
    public class ElectricGuitar : Guitar, IGuitar, IElectricGuitar
    {
        private int numberOfAdapters;
        private int numberOfFrets;

        public ElectricGuitar(string make, string model, decimal price, string color, 
            string bodyWood, string fingerboardWood, int numberOfAdapters, int numberOfFrets)
            : base(make, model, price, color, bodyWood, fingerboardWood, GeneralGuitarNumberOfStrings, true)
        {
            this.NumberOfAdapters = numberOfAdapters;
            this.NumberOfFrets = numberOfFrets;
        }

        public int NumberOfAdapters
        {
            get
            {
                return this.numberOfAdapters;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(NonNegativeParameterMessage, "numberOfAdapters"));
                }

                this.numberOfAdapters = value;
            }
        }

        public int NumberOfFrets
        {
            get
            {
                return this.numberOfFrets;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(PositiveParameterMessage, "numberOfFrets"));
                }

                this.numberOfFrets = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine();
            result.AppendLine(base.ToString());
            result.AppendLine(String.Format("Adapters: {0}", this.NumberOfAdapters));
            result.AppendLine(String.Format("Frets: {0}", this.NumberOfFrets));
            return result.ToString().Trim();
        }
    }
}
