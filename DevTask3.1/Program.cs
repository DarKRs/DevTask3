using System;

namespace DevTask3._1 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = Calc.QuadEquation(1, 2, -3);
            Console.WriteLine("Hello World!");
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}