using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter digit to delete");
            int digit = int.Parse(Console.ReadLine());
            RemoveDigit(number, digit);
            Console.ReadLine();
        }
        static void RemoveDigit(int number,int digit)
        {
            int power = 1;
            int current = 0;
            int result = 0;
            while (number > 0)
            {
                current = number % 10;
                if (current != digit)
                {
                    result += current * power;
                    power *= 10;
                }
                number /= 10;
            }
            Console.WriteLine(result);
        }
    }
}
