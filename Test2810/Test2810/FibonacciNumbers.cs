using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2810
{
    public class FibonacciNumbers
    {
        public void PrintOutFibonacci()
        {
            List<int> fibonacciNumbers = new List<int> { 1, 1 };
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            var previous3 = previous + previous2;
            Console.WriteLine(previous2);

            fibonacciNumbers.Add(previous3);
            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine($"printout {item}");
            }


        }
        


    }
}
