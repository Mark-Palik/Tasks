using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number to reverse");
            int num = int.Parse(Console.ReadLine());
            ReverseNumber(num);
            Console.ReadLine();
        }
        static void ReverseNumber(int num)
        {
            int revnum = 0;
            while (num > 0)
            {
                revnum = revnum * 10 + num % 10;
                num = num / 10;
            }
            Console.WriteLine(revnum);
        }
    }
}
