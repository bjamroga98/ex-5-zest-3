using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5_zest_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print the first 10 elements of the Fibonacci sequence
            for (int i = 0; i < 10; ++i)
                Console.WriteLine(Fibonacci(i));

            Console.ReadKey();
        }
        /*********************************************/
        static long Fibonacci(int n)
        {
            // F0 = 0, F1 = 1
            if (n == 0) return 0;
            if (n == 1) return 1;
            // In other cases, call the function recursively twice,
            // In order to obtain the values of F(n-1) + F(n-2)
            return Fibonacci(n - 1) + Fibonacci(n - 2);

        }
    }
}
