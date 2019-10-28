using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2810
{
    public class Loops
    {
        public void CheckCount()
        {
            //int counter = 0;
            //while (counter < 10)
            //{
            //    Console.WriteLine($"the counter is: {counter}");
            //    counter++;
            //}

            for (int counter = 0; counter < 10; counter++)
            {
                Console.WriteLine($"the counter is: {counter}");
            }

        }

        public void BranchAndLoop()
        {
            int sum = 0;
            for (int i = 0; i < 20; i++)
            {
                //remainder
                if (i % 3 == 0)
                {
                    Console.WriteLine($"Number {i} can be devided to 3");
                    sum = sum + i;
                    Console.WriteLine($"Sum after {i} is {sum}");
                }
         
            }
        }
    }
}
