using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator29
    {
        public double _a;
        public double _b;

        public Calculator29(double a, double b)
            {
                _a = a;
                _b = b;
            }
            public double CalculateX()
            {
                return Math.Exp(2 * _a) + Math.Sqrt(_b);
            }
            public double CalculateP()
            {
                double x = CalculateX();
                return x * (_a + Math.Pow(_b, 3));
            }
            public double CalculateY()
            {
                double p = CalculateP();
                double x = CalculateX();
                return Math.Pow(Math.Log(Math.Abs(p)), 3) + x;
            }
            public void DisplayResults29()
            {
                double y = CalculateY();
                double p = CalculateP();
                double x = CalculateX();

                Console.WriteLine($"y = {y}");
                Console.WriteLine($"p = {p}");
                Console.WriteLine($"x = {x}");
                Console.ReadLine();
            }
    }
}

