using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator22
    {
        public double _m;
        public double _p;

        public Calculator22(double m, double p)
            {
                _m = m;
                _p = p;
            }
            public double CalculateT()
            {
                return Math.Sin(Math.Pow(_m, 3));
            }
            public double CalculateX()
            {
                double t = CalculateT();
                return Math.Pow(_p, 2) + t;
            }
            public double CalculateY()
            {
                double t = CalculateT();
                double x = CalculateX();
                return Math.Pow(Math.Log10(Math.Abs(x + t)), 4);
            }
            public void DisplayResults22()
            {
                double t = CalculateT();
                double x = CalculateX();
                double y = CalculateY();

                Console.WriteLine($"y = {y}");
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"t = {t}");
                Console.ReadLine();
            }
    }
}

