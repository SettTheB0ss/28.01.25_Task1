using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator28
    {
        public double _b;
        public double _k;

        public Calculator28(double b, double k)
            {
                _b = b;
                _k = k;
            }
            public double CalculateT()
            {
                return Math.Pow(_k, 2) + Math.Sqrt(_b);
            }
            public double CalculateA()
            {
                double t = CalculateT();
                return _b + Math.Pow(t, 2) + Math.Exp(t);
            }
            public double CalculateY()
            {
                double a = CalculateA();
                return Math.Pow(Math.Cos(Math.Pow(a, 3) + _b), 4);
            }
            public void DisplayResults28()
            {
                double y = CalculateY();
                double a = CalculateA();
                double t = CalculateT();

                Console.WriteLine($"y = {y}");
                Console.WriteLine($"a = {a}");
                Console.WriteLine($"t = {t}");
                Console.ReadLine();
            }
    }
}

