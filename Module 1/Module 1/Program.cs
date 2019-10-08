using System;


namespace Module_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"x and y before swap x:{x} y:{y}");
            Swap(ref x, ref y);
            Console.WriteLine($"x and y after swap x: {x} y: {y}");
            Console.ReadLine();
        }
        static void Swap(ref int a, ref int b)
        {
            int tmp = a;
            a = b;
            b = tmp;
        }
    }
}
