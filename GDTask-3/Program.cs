using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDTask_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, p, S;
            Console.WriteLine("Введите сторону A: ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону B: ");
            B = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите сторону C: ");
            C = Convert.ToDouble(Console.ReadLine());
            p = (A + B + C) / 2;
            S = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            Console.WriteLine(S);
            Console.ReadKey();
        }
    }
}
