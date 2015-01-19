namespace MusicShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using MusicShopManager.Interfaces;

    public class MusicShop : IMusicShop
    {
        private const string RequiredParameterMessage = "The {0} is required.";

        private string name;
        private IList<IArticle> articles;

        public MusicShop(string name)
        {
            this.Name = name;
            this.Articles = new List<IArticle>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(string.Format(RequiredParameterMessage, "name"));
                }

                this.name = value;
            }
        }

        public IList<IArticle> Articles { get; set; }

        public void AddArticle(IArticle article)
        {
            this.Articles.Add(article);
        }

        public void RemoveArticle(IArticle article)
        {
            this.Articles.Remove(article);
        }

        public string ListArticles()
        {
            var result = new StringBuilder();
            result.AppendFormat("{0} {1} {0}", new string('=', 5), this.Name).AppendLine();
            
            if (this.Articles.Count == 0)
            {
                result.Append("The shop is empty. Come back soon.");
            }
            else
            {
                var articlesList = new List<string>();

                var microphones = this.Articles.Where(a => a is IMicrophone);
                AppendArticlesToList(articlesList, "Microphones", microphones);

                var drums = this.Articles.Where(a => a is IDrums);
                AppendArticlesToList(articlesList, "Drums", drums);

                var electricGuitars = this.Articles.Where(a => a is IElectricGuitar);
                AppendArticlesToList(articlesList, "Electric guitars", electricGuitars);

                var acousticGuitar = this.Articles.Where(a => a is IAcousticGuitar);
                AppendArticlesToList(articlesList, "Acoustic guitars", acousticGuitar);

                var bassGuitar = this.Articles.Where(a => a is IBassGuitar);
                AppendArticlesToList(articlesList, "Bass guitars", bassGuitar);

                result.Append(string.Join(Environment.NewLine, articlesList));
            }

            return result.ToString();
        }

        private void AppendArticlesToList(List<string> articlesList, string title, IEnumerable<IArticle> articles)
        {
            if (articles.Any())
            {
                var sortedArticles = articles.OrderBy(a => a.Make).ThenBy(a => a.Model);
                var articleString = string.Format("{0} {1} {0}{2}{3}",
                    new string('-', 5),
                    title,
                    Environment.NewLine,
                    string.Join(Environment.NewLine, sortedArticles));

                articlesList.Add(articleString);
            }
        }
    }
}
