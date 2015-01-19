using System;
using System.Text;
using MusicShopManager.Interfaces;

namespace MusicShop.Models
{
    public abstract class Instrument : Article, IInstrument, IArticle
    {
        private string color;
        protected bool isElectronic;

        protected Instrument(string make, string model, decimal price, string color, bool isElectronic)
            : base(make, model, price)
        {
            this.Color = color;
            //this.IsElectronic = isElectronic;
        }

        public bool IsElectronic { get; set; }

        public string Color
        {
            get { return this.color; }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(string.Format(RequiredParameterMessage, "color"));
                }

                this.color = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine();
            result.AppendLine(base.ToString());
            result.AppendLine(String.Format("Color: {0}", this.Color));
            result.AppendLine(String.Format("Electronic: {0}", this.isElectronic ? "yes" : "no"));
            return result.ToString().Trim();
        }
    }
}
