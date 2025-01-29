using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator25
    {
        public double _a;
        public double _p;

        public Calculator25(double a, double p)
            {
                _a = a;
                _p = p;
            }
            public double CalculateT()
            {
            return Math.Pow(_a, 3) + Math.Pow(_a, 3);
            }
            public double CalculateX()
            {
                double t = CalculateT();
                return Math.Exp(Math.Sqrt(_p + + _a));
            }
            public double CalculateY()
            {
                double t = CalculateT();
                double x = CalculateX();
                return Math.Pow(x, 3) / Math.Pow(t, 3);
            }
            public void DisplayResults25()
            {
                double y = CalculateY();
                double x = CalculateX();
                double t = CalculateT();

                Console.WriteLine($"y = {y}");
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"t = {t}");
                Console.ReadLine();
            }
    }
}

