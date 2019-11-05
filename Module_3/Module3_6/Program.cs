using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the array");
            int size = int.Parse(Console.ReadLine());
            int[] A = new int[size];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            ChangeArraySigns(A);
            Console.ReadLine();
        }
        static void ChangeArraySigns(int[] A) 
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] *= -1;
                Console.WriteLine(A[i]);
            }
        }
    }
}
