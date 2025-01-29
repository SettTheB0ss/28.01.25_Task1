using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator24
    {
        public double _t;
        public double _b;

        public Calculator24(double t, double b)
            {
                _t = t;
                _b = b;
            }
            public double CalculateA()
            {
                return Math.Pow(_t, 2) * _b;
            }
            public double CalculateX()
            {
                double a = CalculateA();
                return Math.Pow(a, 3) + Math.Sqrt(_t + _b);
            }
            public double CalculateY()
            {
                double x = CalculateX();
                return Math.Cos(Math.Pow(x, 5)) - _b * Math.Pow(Math.Sin(x), 2);
            }
            public void DisplayResults24()
            {
                double y = CalculateA();
                double x = CalculateX();
                double a = CalculateY();

                Console.WriteLine($"y = {y}");
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"a = {a}");
                Console.ReadLine();
            }
    }
}

