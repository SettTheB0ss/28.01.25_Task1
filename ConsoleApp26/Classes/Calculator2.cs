using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator2
    {
        private double _x;
        private double _k;

        public Calculator2(double x, double k)
            {
                _x = x;
                _k = k;
            }
            public double CalculateA()
            {
                return Math.Log10(Math.Abs(_x));
            }
            public double CalculateB()
            {
                double a = CalculateA();
                return Math.Exp(2 * _x) + a * _x;
            }
            public double CalculateY()
            {
                double a = CalculateA();
                double b = CalculateB();
                return _x * Math.Pow(a, 3) + Math.Pow(b, 2);
            }
            public void DisplayResults()
            {
                double a = CalculateY();
                double c = CalculateA();
                double y = CalculateB();

                Console.WriteLine($"a = {a}");
                Console.WriteLine($"c = {c}");
                Console.WriteLine($"y = {y}");
                Console.ReadLine();
            }
    }
}

