using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the array");
            int s = int.Parse(Console.ReadLine());
            int[] A = new int[s];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            PrintIfPrvsIsLess(A);
            Console.ReadLine();
        }
        static void PrintIfPrvsIsLess(int[] A)
        {
            for (int i = 1; i < A.Length; i++)
            {
                if (A[i] > A[i - 1])
                {
                    Console.WriteLine(A[i]);
                }
            }
        }
    }
}
