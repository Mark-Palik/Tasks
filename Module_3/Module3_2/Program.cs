using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many even number you would like to print");
            int n = int.Parse(Console.ReadLine());
            EvenNum(n);
            Console.ReadLine();
        }
        static void EvenNum(int n)
        {
            int a = 2;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(a);
                a += 2;
            }
        }

    }
}
