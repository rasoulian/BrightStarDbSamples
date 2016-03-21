using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightStarDb_App1
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookService = new BookService();
            bookService.Add(1, "test1");
            DisplayBooks(bookService.GetAll());
            Console.ReadKey();
        }

        private static void DisplayBooks(IEnumerable<IBook> books)
        {
            foreach (var book in books)
            {
                Console.WriteLine("{0} {1}", book.Title, book.Code);
            }
        }
    }
}
