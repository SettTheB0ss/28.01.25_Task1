using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator30
    {
        public double _t;
        public double _b;

        public Calculator30(double t, double b)
            {
                _t = t;
                _b = b;
            }
            public double CalculateA()
            {
                return _t + Math.Pow(_b, 3);
            }
            public double CalculateX()
            {
                double a = CalculateA();
                return Math.Pow(_t, 2) * Math.Sqrt(Math.Abs(a + _b));
            }
            public double CalculateY()
            {
                double x = CalculateX();
                double a = CalculateA();
                return Math.Pow(Math.Log10(Math.Abs(x + Math.Pow(a, 2))), 5);
            }
            public void DisplayResults30()
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

