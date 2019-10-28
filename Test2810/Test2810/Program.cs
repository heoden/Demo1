using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2810
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bill";
            string lastName = "Clinton";
            Console.WriteLine($"my friend name is {firstName} and {lastName}");

            Console.WriteLine($"First name has {firstName.Length} letters.");
            Console.WriteLine($"Last name has {lastName.Length} letters.");
        }
    }
}
