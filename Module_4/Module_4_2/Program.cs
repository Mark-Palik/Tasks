using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 3 integers to add");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Add(a, b, c);
            Console.WriteLine("=====================================");
            Console.WriteLine("Enter 2 integers to add");
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            Add(d, e);
            Console.WriteLine("=====================================");
            Console.WriteLine("Enter 3 doubles to add");
            double f = double.Parse(Console.ReadLine());
            double g = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            Add(f, g, h);
            Console.WriteLine("=====================================");
            Console.WriteLine("Enter 2 strings to concatenate");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            Add(s1, s2);
            Console.WriteLine("=====================================");
            Console.WriteLine("Enter Length of 1st array");
            int l1 = int.Parse(Console.ReadLine());
            int[] Arr1 = new int[l1];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < Arr1.Length; i++)
            {
                Arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter Length of 2st array");
            int l2 = int.Parse(Console.ReadLine());
            int[] Arr2 = new int[l2];
            Console.WriteLine("Enter array elements");
            for (int i = 0; i < Arr2.Length; i++)
            {
                Arr2[i] = int.Parse(Console.ReadLine());
            }
            Add(Arr1, Arr2);
            Console.ReadLine();
        }
        static void Add(int a,int b,int c)
        {
            int summ = a + b + c;
            Console.WriteLine(summ);
        }
        static void Add(double a, double b,double c)
        {
            double summ = a + b + c;
            Console.WriteLine(summ);
        }
        static void Add(int a,int b)
        {
            int summ = a + b;
            Console.WriteLine(summ);
        }
        static void Add(string s1, string s2)
        {
            string str3 = s1 + s2;
            Console.WriteLine(str3);
        }
   
        static void Add(int[] A,int[] B)
        {
            int[] C;
            if (A.Length > B.Length)
            {
                int j = 0;
                C = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    if (j >= B.Length)
                    {
                        C[i] += A[i];
                    }
                    else
                    {
                        C[i] = A[i] + B[j];
                        j++;
                    }
                }
                for (int i = 0; i < C.Length; i++)
                {
                    Console.Write(C[i]);
                }
            }
            else if (B.Length > A.Length)
            {
                int j = 0;
                C = new int[B.Length];
                for (int i = 0; i < C.Length; i++)
                {
                    if (j >= A.Length)
                    {
                        C[i] += B[i];
                    }
                    else
                    {
                        C[i] = B[i] + A[j];
                        j++;
                    }
                }
                for (int i = 0; i < C.Length; i++)
                {
                    Console.Write(C[i]);
                }
            }
            else
            {
                C = new int[A.Length];
                for (int i = 0; i < C.Length; i++)
                {
                    C[i] = A[i] + B[i];
                }
                for (int i = 0; i < C.Length; i++)
                {
                    Console.WriteLine(C[i]);
                }
            }
        }
    }
}
