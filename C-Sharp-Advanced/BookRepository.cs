using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Advanced
{
   public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book() {Title = "Title1", Price = 5},
                new Book() {Title = "Title2", Price = 5},
                new Book() {Title = "Title3", Price = 5}
            };
        }
    }
}
