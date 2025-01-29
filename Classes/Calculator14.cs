using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator14
    {
        public double _b;
        public double _k;

        public Calculator14(double b, double k)
            {
                _b = b;
                _k = k;
            }
            public double CalculateT()
            {
                return Math.Pow(_b, 2) + Math.Pow(_k, 3);
            }
            public double CalculateA()
            {
                double t = CalculateT();
                return Math.Sqrt(_b + t);
            }
            public double CalculateY()
            {
                double a = CalculateA();
                return Math.Pow(Math.Sin(Math.Pow(a, 2) + Math.Pow(_b, 2)), 4);
            }
            public void DisplayResults14()
            {
                double t = CalculateT();
                double a = CalculateA();
                double y = CalculateY();

                Console.WriteLine($"t = {t}");
                Console.WriteLine($"a = {a}");
                Console.WriteLine($"y = {y}");
                Console.ReadLine();
            }
    }
}

