using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator19
    {
        public double _x;
        public double _a;

        public Calculator19(double x, double a)
            {
                _x = x;
                _a = a;
            }
            public double CalculateT()
            {
                return Math.Pow(_x, 2) + Math.Pow(_a, 2);
            }
            public double CalculateP()
            {
                double t = CalculateT();
                return Math.Pow(_x, 2) - Math.Sqrt(Math.Abs(_x));
            }
            public double CalculateY()
            {   
                double t = CalculateT();
                double p = CalculateP();
                return _x * Math.Pow(p, 2) + Math.Pow(t, 5);
            }
            public void DisplayResults19()
            {
                double t = CalculateT();
                double p = CalculateP();
                double y = CalculateY();

                Console.WriteLine($"y = {y}");
                Console.WriteLine($"p = {p}");
                Console.WriteLine($"t = {t}");
                Console.ReadLine();
            }
    }
}

