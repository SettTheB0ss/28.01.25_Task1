using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator23
    {
        public double _b;
        public double _x;

        public Calculator23(double b, double x)
            {
                _b = b;
                _x = x;
            }
            public double CalculateT()
            {
                return _x * Math.Pow(_b, 2) + Math.Sqrt(_x);
            }
            public double CalculateA()
            {
                double t = CalculateT();
                return Math.Log(Math.Abs(t * _x + Math.Pow(_b, 2)));
            }
            public double CalculateY()
            {
                double t = CalculateT();
                double a = CalculateA();
                return (Math.Pow(Math.Log10(1), a + _b)) + (Math.Pow(a, 2)) / a + t;
            }
            public void DisplayResults23()
            {
                double t = CalculateT();
                double a = CalculateA();
                double y = CalculateY();

                Console.WriteLine($"y = {y}");
                Console.WriteLine($"a = {a}");
                Console.WriteLine($"t = {t}");
                Console.ReadLine();
            }
    }
}

