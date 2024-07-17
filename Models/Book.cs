using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Book
    {
        public string Title { get;  }
        public Person Author { get; }

        public Book(string title, Person author)
        {
            Title = title;
            Author = author;
        }

        public string Info()
        {
            return $"{Title}, Autor: {Author.GetName()} {Author.LastName}";
        }
    }
}
