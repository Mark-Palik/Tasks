using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter numbers to multiply");
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = Multiplication(b, c);
            Console.WriteLine(d);
            Console.ReadLine();
        }
        static int Multiplication(int a, int b)
        {
            if (a == 0 || b == 0)
                return 0;

            bool negative = false;
            if (a < 0)
            {
                negative = true;
                a = -a;
            }
            if (b < 0)
            {
                negative = !negative;
                b = -b;
            }

            int result = 0;

            for (int i = 1; i <= a; ++i)
                result += b;

            return negative ? -result : result;
        }
    }
}
