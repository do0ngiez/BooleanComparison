using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loop
            bool condition1 = true;
            while (condition1)
            {
                Console.WriteLine("This is a while loop.");
                condition1 = false;
            }

            //do-while loop
            bool condition2 = false;
            do
            {
                Console.WriteLine("This is a do-while loop.");
            } while (condition2);
        }
    }
}
