using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1
{
    class Pr1
    {
        static void Main(string[] args)
        {
            double a, b, c, p;
            Console.Write("Введите длину параллелепипеда: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите ширину параллелепипеда: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите высоту параллелепипеда: ");
            c = Convert.ToDouble(Console.ReadLine());
            p = 2 * (a + b + c);
            Console.WriteLine("Площадь параллелепипеда = {0}", p);
            Console.ReadKey();

        }
    }
}
