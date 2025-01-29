using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator12
    {
        public double _q;
        public double _b;

        public Calculator12(double q, double b)
            {
                _q = q;
                _b = b;
            }
            public double CalculateT()
            {
                return Math.Pow(_b, 3) + Math.Exp(Math.Sqrt(_q));
            }
            public double CalculateX()
            {
                double t = CalculateT();
                return Math.Pow(t, 3) + Math.Pow(_b, 2);
            }
            public double CalculateY()
            {
                double x = CalculateX();
                return Math.Pow(Math.Atan(x),2);
            }
            public void DisplayResults12()
            {
                double t = CalculateT();
                double x = CalculateX();
                double y = CalculateY();

                Console.WriteLine($"t = {t}");
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"y = {y}");
                Console.ReadLine();
            }
    }
}

