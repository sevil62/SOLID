using SRP.Error;
using SRP.Generator;
using SRP.Models;
using SRP.Repository;
using SRP.Validated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aşağıdaki kodları tek sorumluluk prensibine (SRP) göre yazılmıştır..

            //Karşılama
            Message.Greeting();

            //Bilgilerin Girilmesi
            Book book = BookRepository.AddBook();

            //Doğrulama
            bool isValid = BookValidator.Validate(book);
            if (isValid == false)
            {
                Console.ReadLine();
                return;
            }

            //Kaydetme
            BookGenerator.Create(book);
            Console.Read();


        }
    }
}
