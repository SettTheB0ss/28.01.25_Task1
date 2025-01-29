using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator26
    {
        public double _b;
        public double _t;

        public Calculator26(double b, double t)
            {
                _b = b;
                _t = t;
            }
            public double CalculateA()
            {
                return Math.Sqrt(_b + Math.Pow(_t, 2));
            }
            public double CalculateX()
            {
                double a = CalculateA();
                return Math.Pow(Math.Cos(_b), 2) + Math.Pow(Math.Sin(a), 2);
            }
            public double CalculateY()
            {
                double x = CalculateX();
                return Math.Pow(x, 2) + Math.Pow(Math.Abs(x), 1/3);
            }
            public void DisplayResults26()
            {
                double y = CalculateY();
                double x = CalculateX();
                double a = CalculateA();

                Console.WriteLine($"y = {y}");
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"a = {a}");
                Console.ReadLine();
            }
    }
}

