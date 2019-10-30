using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 numbers to enlrage");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Task_4_3_1(ref a, ref b, ref c);
            Console.WriteLine("===========================");
            Console.WriteLine("Enter Length of array");
            int l1 = int.Parse(Console.ReadLine());
            int[] Arr = new int[l1];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            Task_4_3_3(Arr);
            Console.ReadLine();
        }
        static void Task_4_3_1(ref int a,ref int b,ref int c)
        {
            a += 10;
            b += 10;
            c += 10;
            Console.WriteLine($"{a} , {b} , {c}");
        }
        static void Task_4_3_3(int[] A)
        {
            int max = A[0];
            int min = A[0];
            int summ = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > max) max = A[i];
                if (A[i] < min) min = A[i];
                summ += A[i];
            }
            Console.WriteLine($"Max element of array : {max} , Min element of the array : {min} , summ of array elements : {summ}");
        }

    }
}
