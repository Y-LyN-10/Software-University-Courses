using System;
using System.ComponentModel;
using System.Text;
using MusicShopManager.Interfaces;

namespace MusicShop.Models
{
    public class AcousticGuitar : Guitar, IGuitar, IAcousticGuitar, IInstrument, IArticle
    {
        private bool caseIncluded;
        private StringMaterial stringMaterial;

        public AcousticGuitar(string make, string model, decimal price, string color,
            string bodyWood, string fingerboardWood, bool caseIncluded, StringMaterial stringMaterial) :
            base(make, model, price, color, bodyWood, fingerboardWood, GeneralGuitarNumberOfStrings, false)
        {
            this.CaseIncluded = caseIncluded;
            this.StringMaterial = stringMaterial;
            this.IsElectronic = false;
        }

        public bool CaseIncluded { get; set; }

        public StringMaterial StringMaterial
        {
            get
            {
                return this.stringMaterial; 
            }
            set
            {
                if (Enum.IsDefined(typeof (StringMaterial), this.stringMaterial))
                {
                    this.stringMaterial = value;
                }
                else
                {
                    throw new InvalidEnumArgumentException("Sorry, our Master can't craft instrument of this material");
                }
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine();
            result.AppendLine(base.ToString());
            result.AppendLine(String.Format("Case included: {0}", this.CaseIncluded ? "yes" : "no"));
            result.AppendLine(String.Format("String material: {0}", this.StringMaterial));
            return result.ToString().Trim();
        }
    }
}
