using System;
using System.Text;
using MusicShopManager.Interfaces;

namespace MusicShop.Models
{
    public class Drums : Instrument, IDrums, IInstrument
    {
        private int width;
        private int height;

        public Drums(string make, string model, decimal price, string color, int width, int height)
            : base(make, model, price, color, false)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PositiveParameterMessage, "width"));
                }

                this.width = value;
            }
        }

        public int Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PositiveParameterMessage, "height"));
                }

                this.height = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine();
            result.AppendLine(base.ToString());
            result.AppendLine(String.Format("Size: {0}cm x {1}cm", this.Width, this.Height));
            return result.ToString().Trim();
        }
    }
}
