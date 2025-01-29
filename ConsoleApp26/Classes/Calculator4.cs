using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator4
    {
        public double _x;
        public double _t;

        public Calculator4(double x, double t)
            {
                _x = x;
                _t = t;
            }
            public double CalculateA()
            {
                return Math.Log10(_x);
            }
            public double CalculateB()
            {
                return Math.Sqrt(Math.Pow(_x, 2) + Math.Pow(_t, 2));
            }
            public double CalculateY()
            {
                double a = CalculateA();
                double b = CalculateB();
                return Math.Pow(Math.Abs(a - b * _x), 1 / 5);
            }
            public void DisplayResults()
            {
                double a = CalculateA();
                double b = CalculateB();
                double y = CalculateY();

                Console.WriteLine($"a = {a}");
                Console.WriteLine($"b = {b}");
                Console.WriteLine($"y = {y}");
                Console.ReadLine();
            }
    }
}

