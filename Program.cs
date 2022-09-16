using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            double c, d, e, f;
            string s;

            Console.Title = "Калькулятор";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.BufferHeight = 100;
            Console.BufferWidth = 150;
            
            Console.WindowHeight = 40;
            Console.WindowWidth = 100;
            Console.CursorLeft = 10;
            Console.CursorTop = 10;

            
            Console.WriteLine();
            Console.WriteLine("Введите два числа");
            s = Console.ReadLine();
            a = Convert.ToDouble(s);
            s = Console.ReadLine();
            b = Convert.ToDouble(s);
            c = a + b;
            d = a - b;
            e = a * b;
            f = a / b;
            Console.WriteLine("{0}+{1}={2}", a, b, c);
            Console.WriteLine("{0}-{1}={2}", a, b, d);
            Console.WriteLine("{0}*{1}={2}", a, b, e);
            Console.WriteLine("{0}/{1}={2}", a, b, f);
            Console.ReadKey();

            Console.Clear();
                Console.WriteLine("Группа 02, Визирова и Педич");
            Console.ReadKey();



        }
    }
}
