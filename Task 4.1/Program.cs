using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._1
{
    class Program
    {
        private static double Rec(double i, double n)
        {
            return i < n ? Math.Sqrt(i + Rec(++i, n)) : Math.Sqrt(i);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите N: ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Результат: " + n / Rec(1, n));
            Console.ReadLine();
        }
    }
}

