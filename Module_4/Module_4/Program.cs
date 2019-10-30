using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of the array");
            int size = int.Parse(Console.ReadLine());
            int[] Arr = new int[size];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Difference between max and min elemnts is :");
            Difference(Arr);
            Console.WriteLine($"Max element of the array is : {MaxElem(Arr)}");
            Console.WriteLine($"Min element of the array is : {MinElem(Arr)}");
            Console.WriteLine("Summ of array elements is : ");
            Summ(Arr);
            Console.WriteLine("==============================================");
            Console.WriteLine("Adding to even elements max element of the array and subtracting from odd min element");
            Task4_1_D(Arr);
            Console.ReadLine();
        }
        static int MaxElem(int[] Arr)
        {
            int max = Arr[0];
            for (int i = 0; i < Arr.Length; i++)
            {
                if(Arr[i] > max)
                {
                    max = Arr[i];
                }
            }
            return max;
        }
        static int MinElem(int[] Arr)
        {
            int min = Arr[0];
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] < min)
                {
                    min = Arr[i];
                }
            }
            return min;
        }
        static void Summ(int[] Arr)
        {
            int summ = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                summ += Arr[i];
            }
            Console.WriteLine(summ);
        }
        static void Difference(int[] Arr)
        {
            int max = MaxElem(Arr);
            int min = MinElem(Arr);
            int d = max - min;
            Console.WriteLine(d);
        }
        static void Task4_1_D(int[] Arr)
        {
            int max = MaxElem(Arr);
            int min = MinElem(Arr);
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] % 2 == 0)
                {
                    Arr[i] += max;
                }
                else
                {
                    Arr[i] -= min;
                }
            }
            for (int i = 0; i < Arr.Length; i++)
            {
                Console.Write(Arr[i] );
            }
        }
    }
}
