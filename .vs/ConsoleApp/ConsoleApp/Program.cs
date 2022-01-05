using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите число");
            string x = Console.ReadLine();
            int a = Convert.ToInt32(x);
            a = a * a;
            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
