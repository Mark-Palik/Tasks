using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Congratulations(n);
            Console.ReadLine();
        }
        static void Congratulations(int n)
        {
            if (n >= 18 && n % 2 == 0)
            {
                Console.WriteLine("Congratulations you're 18");
            }
            else if (n % 2 != 0 && n < 18 && n > 13)
            {
                Console.WriteLine("Congratulations you're in the high school now");
            }
            Console.WriteLine("End of subtask 2.2");

        }
    }
}
