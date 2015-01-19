using System;
using System.Text;
using MusicShopManager.Interfaces;

namespace MusicShop.Models
{
    public class BassGuitar : Guitar, IGuitar, IBassGuitar, IInstrument, IArticle
    {
        private const int GeneralBassNumberOfStrings = 4;

         public BassGuitar(string make, string model, decimal price, string color, 
            string bodyWood, string fingerboardWood) :
            base(make, model, price, color, bodyWood, fingerboardWood, GeneralBassNumberOfStrings, true)
         {
         }

         public override string ToString()
         {
             var result = new StringBuilder();
             result.AppendLine(base.ToString());
             return result.ToString().Trim();
         }
    }
}
