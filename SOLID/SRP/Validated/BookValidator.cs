using SRP.Error;
using SRP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Validated
{
    public class BookValidator
    {
        public static bool Validate(Book book)
        {
            if (string.IsNullOrWhiteSpace(book.BookName))
            {
                Message.ErrorMessage("BookName");
                return false;
            }
            if (string.IsNullOrWhiteSpace(book.AuthorName))
            {
                Message.ErrorMessage("AuthorName");
                return false;
            }
            return true;
        }


    }
}
