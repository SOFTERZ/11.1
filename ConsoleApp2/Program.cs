using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите целое число x");
            int x = int.Parse(Console.ReadLine());
            double r1 = Math.Pow(x, 2);

            Console.WriteLine("введите целое число y");
            int y = int.Parse(Console.ReadLine());
            double r2 = Math.Pow(y, 2);

            Console.WriteLine("квадрат меньшего из чисел");
            double r3 = Math.Min(r1, r2);
            Console.WriteLine(r3);

            Console.ReadKey();
        }
    }
}