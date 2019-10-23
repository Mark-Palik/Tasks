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
            Console.WriteLine("Enter size of the array");
            int s = int.Parse(Console.ReadLine());
            int[] a = new int[s];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            task7(a);
            Console.WriteLine("Enter numbers to multiply");
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Multiplication(b, c);
            Console.WriteLine("Enter number");
            string r = Console.ReadLine();
            Console.WriteLine("Enter digit to delete");
            char d = char.Parse(Console.ReadLine());
            removeNumber(r, d);
            Console.WriteLine("Enter number to reverse");
            string number = Console.ReadLine();
            arrReverse(number);
            Console.WriteLine("Enter how many even number you would like to print");
            int n = int.Parse(Console.ReadLine());
            evenNum(n);
            Console.WriteLine("Enter how many fibonachi numbers you would like to print");
            int f = int.Parse(Console.ReadLine());
            Fib(f);
            Console.WriteLine("Enter size of the array");
            int size = int.Parse(Console.ReadLine());
            int[] A = new int[size];
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = int.Parse(Console.ReadLine());
            }
            changeArr(A);
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]);
            }
            Console.WriteLine();
            task8_2();
            Console.ReadLine();
        }
        static void Multiplication(int first, int second)
        {
            int result = 0;
            if (first < 0 && second < 0)
            {
                first *= -1;
                second *= -1;
                for (int i = 1; i <= second; i++)
                {
                    result += first;
                }
                Console.WriteLine(result);
            }
            else if (first < 0)
            {
                first *= -1;
                for (int i = 1; i <= second; i++)
                {
                    result += first;
                }
                Console.WriteLine(result * (-1));
            }
            else if (second < 0)
            {
                second *= -1;
                for (int i = 1; i <= second; i++)
                {
                    result += first;
                }
                Console.WriteLine(result * (-1));
            }
            else
            {
                for (int i = 1; i <= second; i++)
                {
                    result += first;
                }
                Console.WriteLine(result);
            }
        }
        static void removeNumber(string number, char digitTodelete)
        {
            char[] b = new char[number.Length - 1];
            for (int i = 0, k = 0; i < number.Length; i++)
            {
                if (number[i] == digitTodelete)
                { continue; }
                b[k] = number[i];
                k++;
            }
            string str = new string(b);
            int result = int.Parse(str);
            Console.WriteLine(result);
        }
        static void arrReverse(string str)
        {
            char[] arr = str.ToCharArray();
            char tmp;
            for (int i = 0; i < str.Length / 2; i++)
            {
                tmp = arr[i];
                arr[i] = arr[str.Length - i - 1];
                arr[str.Length - i - 1] = tmp;
            }
            string str1 = new string(arr);
            int b = int.Parse(str1);
            Console.WriteLine(b);
        }
        static void evenNum(int n)
        {
            int a = 2;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(a);
                a += 2;
            }
        }
        static void Fib(int n)
        {
            int fib1 = 0;
            int fib2 = 1;
            int b = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(fib1 + fib2);
                b = fib1 + fib2;
                fib1 = fib2;
                fib2 = b;
            }
        }
        static void changeArr(int[] A) // changing signs of each array's element
        {
            for (int i = 0; i < A.Length; i++)
            {
                A[i] *= -1;
            }

        }
        static void task7(int[] a) // printing array element if previous is smaller 
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (i > 0 && a[i] > a[i - 1])
                {
                    Console.WriteLine(a[i]);
                }
            }

        }
        static void task8_2() // spiral matrix
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
    }
}

