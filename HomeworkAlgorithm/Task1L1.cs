using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAlgorithm
{
    public class Task1L1
    {
        public static void check(long number)
        {
            int d = 0; int i = 2;
            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                    i++;
                }
                else
                {
                    i++;
                }
            }

            if (d == 0 && number != 1)
                {
                    Console.WriteLine("Number is simple");
                }
            else
                {
                    Console.WriteLine("Number is not simple");
                }
        }

    }
}
