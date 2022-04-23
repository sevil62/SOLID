using SRP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Repository
{
    public class BookRepository
    {
        public static Book AddBook()
        {
            Book book = new Book();
            Console.WriteLine("Lütfen Kitap adını giriniz");
            book.BookName=Console.ReadLine();
            Console.WriteLine("Lütfena Kitabın Yazar Adını giriniz");
            book.AuthorName = Console.ReadLine();
            return book;

        }
    }
}
