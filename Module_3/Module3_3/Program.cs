using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many fibonachi numbers you would like to print");
            int f = int.Parse(Console.ReadLine());
            Fib(f);
            Console.ReadLine();
        }
        static void Fib(int n)
        {
            int fib1 = 0;
            int fib2 = 1;
            int b = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(fib1 + fib2);
                b = fib1 + fib2;
                fib1 = fib2;
                fib2 = b;
            }
        }
    }
}
