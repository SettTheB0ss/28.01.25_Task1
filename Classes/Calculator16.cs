using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator16
    {
        public double _x;
        public double _c;

            public Calculator16(double x, double c)
            {
                _x = x;
                _c = c;
            }
            public double CalculateB()
            {
                return _x + Math.Pow(_c, 2);
            }
            public double CalculateA()
            {
                double b = CalculateB();
                return Math.Pow(Math.Abs(b + _c), 1/3);
            }
            public double CalculateY()
            {
            double b = CalculateB();
            double a = CalculateA();
                return Math.Pow(Math.Cos(b), 2) + b * Math.Pow(Math.Cos(Math.Pow(a, 2)), 4);
            }
            public void DisplayResults16()
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

