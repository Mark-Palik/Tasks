using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_2._1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("please enter number of companies, profit for each company and tax rate");
            int compNum = int.Parse(Console.ReadLine());
            int profit = int.Parse(Console.ReadLine());
            int taxRate = int.Parse(Console.ReadLine());
            Taxes(compNum, profit, taxRate);
            Console.ReadLine();

        }
        static void Taxes(int compNum, int profit, int taxRate)
        {
            int totalCmpProfit = profit * compNum;
            float stateProfit = (profit * compNum) * ((float)taxRate / 100);
            Console.WriteLine($"state profit is : {stateProfit}");
            Console.WriteLine("End of subtask 2.1");
        }
    }
}
