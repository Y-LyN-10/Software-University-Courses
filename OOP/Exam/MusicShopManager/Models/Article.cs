using System;
using System.Text;
using MusicShopManager.Interfaces;

namespace MusicShop.Models
{
    public abstract class Article : IArticle
    {
        protected const string RequiredParameterMessage = "The {0} is required.";
        protected const string PositiveParameterMessage = "The {0} must be positive.";
        protected const string NonNegativeParameterMessage = "The {0} must be positive."; // non-negative

        protected string make;
        private string model;
        private decimal price;

        public Article(string make, string model, decimal price)
        {
            this.Make = make;
            this.Model = model;
            this.Price = price;
        }

        public string Make
        {
            get
            {
                return this.make;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(string.Format(RequiredParameterMessage, "make"));
                }

                this.make = value;
            }
        }

        public string Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(string.Format(RequiredParameterMessage, "model"));
                }

                this.model = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(string.Format(PositiveParameterMessage, "price"));
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine();
            result.AppendLine(string.Format("{0} {1} {2} {0}", "=", this.Make, this.Model));
            result.AppendLine(string.Format("Price: ${0:F2}", this.Price));
            return result.ToString().Trim();
        }
    }
}
