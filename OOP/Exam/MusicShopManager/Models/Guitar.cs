using System;
using System.Text;
using MusicShopManager.Interfaces;

namespace MusicShop.Models
{
    public abstract class Guitar : Instrument, IGuitar, IInstrument, IArticle
    {
        protected const int GeneralGuitarNumberOfStrings = 6;
        
        protected string bodyWood;
        protected string fingerboardWood;
        private int numberOfStrings = 6;

        protected Guitar(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood, int numberOfStrings, bool isElectronic)
            : base(make, model, price, color, isElectronic)
        {
            this.BodyWood = bodyWood;
            this.FingerboardWood = fingerboardWood;
            this.NumberOfStrings = numberOfStrings;
        }

        public string BodyWood
        {
            get
            {
                return this.bodyWood;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(string.Format(RequiredParameterMessage, "bodyWood"));
                }

                this.bodyWood = value;
            }
        }

        public string FingerboardWood
        {
            get
            {
                return this.fingerboardWood;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(string.Format(RequiredParameterMessage, "fingerboardWood"));
                }

                this.fingerboardWood = value;
            }
        }

        public int NumberOfStrings
        {
            get
            {
                return this.numberOfStrings;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(NonNegativeParameterMessage, "Number Of Strings"));
                }

                this.numberOfStrings = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine(String.Format("Strings: {0}", this.NumberOfStrings));
            result.AppendLine(String.Format("Body wood: {0}", this.BodyWood));
            result.AppendLine(String.Format("Fingerboard wood: {0}", this.FingerboardWood));
            return result.ToString().Trim();
        }
    }
}
