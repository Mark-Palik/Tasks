using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length of the array");
            int l1 = int.Parse(Console.ReadLine());
            int[] Arr = new int[l1];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < Arr.Length; i++)
            {
                Arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter 0 for ascending sorting and 1 for dedscending");
            int a = int.Parse(Console.ReadLine());
            Sort(Arr, a);
            for(int i =0;i<Arr.Length;i++)
            {
                Console.WriteLine(Arr[i]);    
            }
            
            Console.ReadLine();
        }
        static void Sort(int[] A,int d)
        {
            int tmp = 0;
            if (d == 0)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    for (int j = i+1; j < A.Length; j++)
                    {
                        if (A[i] > A[j])
                        {
                            tmp = A[i];
                            A[i] = A[j];
                            A[j] = tmp;
                        }
                    }
                }
            }
            if (d == 1)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    for (int j = i + 1; j < A.Length; j++)
                    {
                        if (A[i] < A[j])
                        {
                            tmp = A[i];
                            A[i] = A[j];
                            A[j] = tmp;
                        }
                    }
                }
            }
        }
    }
}
