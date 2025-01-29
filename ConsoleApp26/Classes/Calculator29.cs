using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator2
    {
        public double _x;
        public double _k;

        public Calculator2(double x, double k2)
            {
                _x = x;
                _k = k2;
            }
            public double CalculateA()
            {
                return Math.Log10(_x);
            }
            public double CalculateC()
            {
                double a = CalculateA();
                return Math.Pow(a, 2) + Math.Sqrt(_x);
            }
            public double CalculateY()
            {
                double c = CalculateC();
                return Math.Exp(2 * _x) + 9.7 * c;
            }
            public void DisplayResults()
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

