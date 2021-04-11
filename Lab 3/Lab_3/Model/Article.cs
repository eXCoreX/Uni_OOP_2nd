using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3.Model
{
    class Article
    {
        public Article(Author author, string name, int pageCount, int fee)
        {
            Author = author;
            Name = name;
            PageCount = pageCount;
            Fee = fee;
        }

        private Author author;

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

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value ?? throw new ArgumentNullException("Article name can't be null");
            }
        }

        private int pageCount;

        public int PageCount
        {
            get 
            { 
                return pageCount; 
            }
            set 
            { 
                pageCount = value; 
            }
        }

        private int fee;

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
            return $"{Name} by {Author.FirstName} {Author.LastName}, {PageCount} p.";
        }
    }
}
