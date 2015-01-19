using System;
using System.Management.Instrumentation;
using System.Text;
using MusicShopManager.Interfaces;

namespace MusicShop.Models
{
    public class Microphone : Article, IMicrophone, IArticle
    {
        public Microphone(string make, string model, decimal price, bool hasCable)
            : base(make, model, price)
        {
            this.HasCable = hasCable;
        }

        public bool HasCable { get; private set; }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.AppendLine(base.ToString());
            result.AppendLine(String.Format("Cable: {0}", this.HasCable ? "yes" : "no"));
            return result.ToString().Trim();
        }
    }
}
