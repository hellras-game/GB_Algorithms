using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAlgorithm
{
    class Task2L1
    {
        public static void recFibonacci(int n)
        {
            static int fib(int n)
            {
                return n > 1 ? fib(n - 1) + fib(n - 2) : n;
            }
            Console.WriteLine("Recursive. Your number is " + fib(n - 1));
        }

        public static void cycleFibonacci(int n)
        {
            int f1 = 0, f2 = 1, fF = 0;
            if (n == 1) fF = f1;
            else if (n == 2) fF = f2;
            for(int i = 2; i < n; i++)
            {
                fF = f1 + f2;
                f1 = f2;
                f2 = fF;
            }
            Console.WriteLine("Cycle. Your number is " + fF);
        }
    }
}
