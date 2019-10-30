using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of array");
            int l1 = int.Parse(Console.ReadLine());
            int[] Arr = new int[l1];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            Addfive(Arr);
            Console.ReadLine();
        }
        static void Addfive(int[] A)
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] += 5;
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]);
            }
        }
    }
}
