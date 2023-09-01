using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibanacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci_Iterative(16);
            System.Console.ReadKey();
        }

        public static void Fibonacci_Iterative(int len)

        {

            int a = 0;
            int b = 1;
            int c = 0;

            Console.Write("{0} {1}", a, b);



            for (int i = 2; i < len; i++)

            {

                c = a + b;

                Console.Write(" {0}", c);

                a = b;

                b = c;

            }

        }
    }
}
