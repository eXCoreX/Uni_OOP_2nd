using Lab_3.Helpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using System.Text;

namespace Lab_3.Models
{
    [DataContract]
    public class Magazine : PropertyChangedNotifier, ICloneable, IEquatable<Magazine>
    {
        public Magazine(Periodicity periodicity, string name)
        {
            Periodicity = periodicity;
            Title = name;
            Articles = new ObservableCollection<Article>();
        }

        private Periodicity periodicity;

        [DataMember]
        public Periodicity Periodicity
        {
            get 
            { 
                return periodicity; 
            }
            set 
            { 
                periodicity = value;
                OnPropertyChanged(nameof(Periodicity));
            }
        }

        private string title;

        [DataMember]
        public string Title
        {
            get 
            { 
                return title; 
            }
            set 
            {
                title = value ?? throw new ArgumentNullException("Magazine name can't be null");
                OnPropertyChanged(nameof(Title));
                OnPropertyChanged(nameof(ShortDescription));
            }
        }

        private ObservableCollection<Article> articles;

        [DataMember]
        public ObservableCollection<Article> Articles
        {
            get 
            { 
                return articles; 
            }
            set 
            { 
                articles = value;
                OnPropertyChanged(nameof(Articles));
                OnPropertyChanged(nameof(ShortDescription));
            }
        }

        public string ShortDescription
        {
            get
            {
                return ToShortString();
            }
        }

        public void AddArticle(Article article)
        {
            if (article == null)
            {
                throw new ArgumentNullException("Article can't be null");
            }
            articles.Add(article);
            OnPropertyChanged(nameof(Articles));
            OnPropertyChanged(nameof(ShortDescription));
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Title}:\n");
            int totalPageCount = 0;

            foreach (var article in Articles)
            {
                totalPageCount += article.PageCount;
                sb.Append($"{article}\n");
            }

            sb.Append($"Total page count: {totalPageCount}\n");
            sb.Append($"Published: {Periodicity}");

            return sb.ToString();
        }

        public string ToShortString()
        {
            int totalPageCount = 0;
            foreach (var article in Articles)
            {
                totalPageCount += article.PageCount;
            }

            return $"{Title}, {totalPageCount} p.";
        }

        public object Clone()
        {
            var articlesClone = new ObservableCollection<Article>();
            foreach (var article in Articles)
            {
                articlesClone.Add(article.Clone() as Article);
            }
            var magClone = new Magazine(Periodicity, Title)
            {
                Articles = articlesClone
            };
            return magClone;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Magazine);
        }

        public bool Equals(Magazine other)
        {
            return other != null &&
                   Periodicity == other.Periodicity &&
                   Title == other.Title &&
                   EqualityComparer<ObservableCollection<Article>>.Default.Equals(Articles, other.Articles);
        }

        public override int GetHashCode()
        {
            int hashCode = -1033295748;
            hashCode = hashCode * -1521134295 + Periodicity.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<ObservableCollection<Article>>.Default.GetHashCode(Articles);
            return hashCode;
        }

        public static bool operator ==(Magazine left, Magazine right)
        {
            return EqualityComparer<Magazine>.Default.Equals(left, right);
        }

        public static bool operator !=(Magazine left, Magazine right)
        {
            return !(left == right);
        }
    }
}
