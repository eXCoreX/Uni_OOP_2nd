using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Model
{
    class Magazine
    {
        public Magazine(Periodicity periodicity, string name)
        {
            Periodicity = periodicity;
            Name = name;
            Articles = new List<Article>();
        }

        private Periodicity periodicity;

        public Periodicity Periodicity
        {
            get 
            { 
                return periodicity; 
            }
            set 
            { 
                periodicity = value; 
            }
        }

        private string name;

        public string Name
        {
            get 
            { 
                return name; 
            }
            set 
            {
                name = value ?? throw new ArgumentNullException("Magazine name can't be null"); 
            }
        }

        private List<Article> articles;

        public List<Article> Articles
        {
            get 
            { 
                return articles; 
            }
            set 
            { 
                articles = value; 
            }
        }

        public void AddArticle(Article article)
        {
            if (article == null)
            {
                throw new ArgumentNullException("Article can't be null");
            }
            articles.Add(article);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name}:\n");
            int totalPageCount = 0;

            foreach (var article in Articles)
            {
                totalPageCount += article.PageCount;
                sb.Append($"{article}\n");
            }

            sb.Append($"Total page count: {totalPageCount}");

            return sb.ToString();
        }

        public string ToShortString()
        {
            int totalPageCount = 0;
            foreach (var article in Articles)
            {
                totalPageCount += article.PageCount;
            }

            return $"{Name}, {totalPageCount} p.";
        }
    }
}
