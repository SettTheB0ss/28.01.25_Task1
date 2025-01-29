using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator20
    {
        public double _x;
        public double _p;

        public Calculator20(double x, double p)
            {
                _x = x;
                _p = p;
            }
            public double CalculateB()
            {
                return Math.Pow(_x, 4) + Math.Log10(Math.Pow(_p, 3));
            }
            public double CalculateA()
            {
                double b = CalculateB();
                return Math.Sin(Math.Pow(_x, 2) + Math.Pow(b, 2));
            }
            public double CalculateY()
            {
                double b = CalculateA();
                double a = CalculateA();
                return Math.Log10(a) / Math.Log10(Math.Pow(b,3));
            }
            public void DisplayResults20()
            {
                double b = CalculateB();
                double a = CalculateA();
                double y = CalculateY();

                Console.WriteLine($"y = {y}");
                Console.WriteLine($"a = {a}");
                Console.WriteLine($"b = {b}");
                Console.ReadLine();
            }
    }
}

