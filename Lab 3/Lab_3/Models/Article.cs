using System;
using System.Runtime.Serialization;

namespace Lab_3.Models
{
    [DataContract]
    public class Article : ICloneable
    {
        public Article(Author author, string name, int pageCount, int fee)
        {
            Author = author;
            Title = name;
            PageCount = pageCount;
            Fee = fee;
        }

        private Author author;

        [DataMember]
        public Author Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value ?? throw new ArgumentNullException("Author can't be null");
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
                title = value ?? throw new ArgumentNullException("Article name can't be null");
            }
        }

        private int pageCount;

        [DataMember]
        public int PageCount
        {
            get 
            { 
                return pageCount; 
            }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Page count can't be less than 0");
                }
                pageCount = value; 
            }
        }

        private int fee;

        [DataMember]
        public int Fee
        {
            get 
            {
                return fee; 
            }
            set 
            { 
                fee = value; 
            }
        }

        public override string ToString()
        {
            return $"{Title} by {Author.FirstName} {Author.LastName}, {PageCount} p.";
        }

        public object Clone()
        {
            var authorClone = Author.Clone() as Author;
            return new Article(authorClone, Title, PageCount, Fee);
        }
    }
}
