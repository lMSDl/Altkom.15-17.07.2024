using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Library
    {
        List<Book> _booksList;

        public Library()
        {
            _booksList = new List<Book>();
        }

        public void Add(Book book)
        {
            _booksList.Add(book);
        }

        public void ShowBooks()
        {
            foreach (var item in _booksList)
            {
                Console.WriteLine(item.Info());
            }
        }
    }
}
