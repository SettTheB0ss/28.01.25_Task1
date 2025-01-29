using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator10
    {
        public double _x;
        public double _b;

            public Calculator10(double x, double b)
            {
                _x = x;
                _b = b;
            }
            public double CalculateA()
            {
                return Math.Pow(_b, 3) + Math.Log10(Math.Abs(_b));
            }
            public double CalculateC()
            {
                double a = CalculateA();
                return Math.Pow(a, 2) + Math.Sqrt(_b);
            }
            public double CalculateY()
            {
                double c = CalculateC();
                return Math.Exp(_x) + Math.Pow(5.8, c);
            }
            public void DisplayResults10()
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

