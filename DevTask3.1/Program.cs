using System;

namespace DevTask3._1 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string?buf;
            double[] koef;
            double a, b, c;
            Console.WriteLine("Данное консольное приложение решает квадратные уравнения. Введите 'exit' если хотите выйти\n");
            do
            {
                Console.WriteLine("Введите коэфициенты через пробел - прим. (1 2 -3):");
                buf = Console.ReadLine();
                try
                {
                    koef = buf.Split(' ')
                        .Where(x => !string.IsNullOrEmpty(x))
                        .Select(x => Convert.ToDouble(x)).ToArray();
                }
                catch(Exception ex)
                {
                    if(buf != "exit")
                        Console.WriteLine("\nКоэфициенты введены неправильно");
                    continue;
                }
                Console.WriteLine("\nРезультаты X1, X2:");
                Console.WriteLine(Calc.QuadEquation(koef[0], koef[1], koef[2]));
            } while(buf != "exit");

            Console.WriteLine("\nВыполнение приложения прервано");
            Console.ReadKey();
        }
    }
}