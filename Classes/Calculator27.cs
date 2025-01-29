using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator27
    {
        public double _t;
        public double _a;

        public Calculator27(double t, double a)
            {
                _t = t;
                _a = a;
            }
            public double CalculateC()
            {
                return Math.Pow(_t, 2) + Math.Sqrt(_a);
            }
            public double CalculateX()
            {
                double c = CalculateC();
                return Math.Log10(Math.Abs(c * _t)) + Math.Pow(_a, 2);
            }
            public double CalculateY()
            {
                double x = CalculateX();
                return Math.Tan(4 * x) + Math.Sin(Math.Pow(x, 2));
            }
            public void DisplayResults27()
            {
                double y = CalculateY();
                double x = CalculateX();
                double c = CalculateC();

                Console.WriteLine($"y = {y}");
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"c = {c}");
                Console.ReadLine();
            }
    }
}

