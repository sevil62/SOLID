using SRP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Generator
{
    public class BookGenerator
    {
        public static void Create(Book book)
        {
            Console.WriteLine(book.BookName + " " + book.AuthorName);
        }
    }
}
