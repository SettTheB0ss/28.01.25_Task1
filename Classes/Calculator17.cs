using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator17
    {
        public double _x;
        public double _t;

        public Calculator17(double x, double t)
            {
                _x = x;
                _t = t;
            }
            public double CalculateB()
            {
                return Math.Pow(Math.Log10(Math.Abs(_x)), 2);
            }
            public double CalculateA()
            {
                double b = CalculateB();
                return _t * _x + Math.Abs(Math.Sqrt(b));
            }
            public double CalculateY()
            {
                double b = CalculateB();
                double a = CalculateA();
                return Math.Pow(Math.Cos(a + Math.Pow(b, 3)), 3);
            }
            public void DisplayResults17()
            {
                double b = CalculateB();
                double a = CalculateA();
                double y = CalculateY();

                Console.WriteLine($"b = {b}");
                Console.WriteLine($"a = {a}");
                Console.WriteLine($"y = {y}");
                Console.ReadLine();
            }
    }
}

