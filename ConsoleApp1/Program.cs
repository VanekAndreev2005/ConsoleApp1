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
            float a, b, c;

            Console.WriteLine("Введите первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToInt32(Console.ReadLine());
            c = a + b;
            Console.WriteLine("Результат с = " + c);

            float d;

            Console.WriteLine("Введитaе первое число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = Convert.ToInt32(Console.ReadLine());
            d = a * b;
            Console.WriteLine("Результат d = " +d);

        }
        private void C(float c)
        {
            Console.WriteLine(+c);
        }

        private void d(float d)
        {
            Console.WriteLine(+d);
           
        }

    }
}
