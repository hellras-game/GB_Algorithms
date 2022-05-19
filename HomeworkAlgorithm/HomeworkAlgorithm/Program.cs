using System;

namespace HomeworkAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int taskNumb()
            {
                Console.WriteLine("Choose task number (1 or 3)");
                int a = Convert.ToInt32(Console.ReadLine());
                return a;
            }

            switch (taskNumb())
            {
                case 1: l1Task1();
                    break;
                case 3: l1Task3();
                    break;
                default: Console.WriteLine("Wrong task number");
                    break;
            }

            void l1Task1()
            {
                Console.WriteLine("Enter an integer");
                long number = Convert.ToInt64(Console.ReadLine());
                Task1L1.check(number);
            }

            void l1Task3()
            {
                Console.WriteLine("Enter the index of the Fibonacci number");
                int n = Convert.ToInt32(Console.ReadLine());
                Task2L1.recFibonacci(n);
                Task2L1.cycleFibonacci(n);
            }

        }

    }
}
