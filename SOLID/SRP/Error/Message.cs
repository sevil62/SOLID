using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.Error
{
    public class Message
    {
        public static void Greeting()
        {
            Console.WriteLine("Welcame...");
        }
        public static void ErrorMessage(string fieldName)
        {
            Console.WriteLine($"{fieldName} not found");
        }
    }
}
