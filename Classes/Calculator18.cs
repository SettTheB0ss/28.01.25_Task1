using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator18
    {
        public double _x;
        public double _b;

        public Calculator18(double x, double b)
            {
                _x = x;
                _b = b;
            }
            public double CalculateA()
            {
                return Math.Sqrt(Math.Abs(_x)) + Math.Exp(Math.Sqrt(_b));
            }
            public double CalculateC()
            {
                double a = CalculateA();
                return Math.Log10(a) + Math.Pow(_b, 2);
            }
            public double CalculateY()
            {
                double a = CalculateA();
                double c = CalculateC();
                return Math.Pow(a, 3) / Math.Cos(c);
            }
            public void DisplayResults18()
            {
                double a = CalculateA();
                double c = CalculateC();
                double y = CalculateY();

                Console.WriteLine($"a = {a}");
                Console.WriteLine($"c = {c}");
                Console.WriteLine($"y = {y}");
                Console.ReadLine();
            }
    }
}

