using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator15
    {
        public double _a;
        public double _p;

        public Calculator15(double a, double p)
            {
                _a = a;
                _p = p;
            }
            public double CalculateB()
            {
                return Math.Abs(_a) + Math.Sqrt(_a + Math.Pow(_p, 2)) ;
            }
            public double CalculateX()
            {
                double b = CalculateB();
                return Math.Exp(b);
            }
            public double CalculateY()
            {
                double x = CalculateX();
                return Math.Pow(Math.Cos(x),3) + Math.Abs(_a);
            }
            public void DisplayResults15()
            {
                double b = CalculateB();
                double x = CalculateX();
                double y = CalculateY();

                Console.WriteLine($"b = {b}");
                Console.WriteLine($"c = {x}");
                Console.WriteLine($"y = {y}");
                Console.ReadLine();
            }
    }
}

