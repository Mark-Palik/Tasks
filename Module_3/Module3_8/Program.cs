using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            FillingBySpiral();
            DivisionByHalf();
            Console.ReadLine();
        }
        static void DivisionByHalf()
        {
            double accuracy = 0.0001;
            double left = -3;
            double right = 0;
            var length = right - left;
            var err = length;
            double x = 0;
            while (err > accuracy && F(x) != 0)
            {
                x = (left + right) / 2;
                if (F(left) * F(x) < 0)
                {
                    right = x;
                }
                else if (F(x) * F(right) < 0)
                {
                    left = x;
                }
                err = (right - left) / length;
            }
            Console.WriteLine(x);

        }
        static void FillingBySpiral()
        {
            while (true)
            {
                Console.Write("Enter matrix's size (0 - exit): ");

                int n;
                if (!Int32.TryParse(Console.ReadLine(), out n) || n <= 0) break;

                Console.WriteLine();

                int[,] a = new int[n, n];

                int i = 0, j = 0;

                int value = 1;

                while (n != 0)
                {
                    int k = 0;
                    do { a[i, j++] = value++; } while (++k < n - 1);
                    for (k = 0; k < n - 1; k++) a[i++, j] = value++;
                    for (k = 0; k < n - 1; k++) a[i, j--] = value++;
                    for (k = 0; k < n - 1; k++) a[i--, j] = value++;

                    ++i; ++j; n = n < 2 ? 0 : n - 2;
                }

                DisplayArray(a);
                Console.WriteLine();
            }
        }
        static void DisplayArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++) Console.Write("{0,3} ", a[i, j]);
                Console.WriteLine();
            }
        }
        public static double F(double x)
        {
            return -x * x + x + 6;
        }
    }
}
