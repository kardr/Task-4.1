using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4._1
{
    class Program
    {
        private static double Rec(double i, int n)
        {
            return i < n ? Math.Sqrt(i + Rec(++i, n)) : Math.Sqrt(i);
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите N: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0)
                {
                    Console.WriteLine("Результат: " + n / Rec(1, n));
                }
                else if (n < 0)
                    Console.WriteLine("Ошибка: N меньше 0");
                else if (n == 0)
                    Console.WriteLine("Ошибка: N = 0");
            }
            catch(Exception E)
            {
                Console.WriteLine(E.Message);
            }
            Console.ReadLine();
        }
    }
}

