using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator6
    {
        public double _m;
        public double _x;

        public Calculator6(double m, double x)
            {
                _m = m;
                _x = x;
            }
            public double CalculateA()
            {
                return Math.Sqrt(Math.Abs(_x));
            }
            public double CalculateB()
            {
                return Math.Pow(_x, 4) + Math.Pow(_m, 2);
            }
            public double CalculateY()
            {
                double a = CalculateA();
                double b = CalculateB();
            return Math.Pow(Math.Sin(a + Math.Pow(Math.Tan(b), 3)), 2);
            }
            public void DisplayResults()
            {
                double a = CalculateA();
                double b = CalculateB();
                double y = CalculateY();

                Console.WriteLine($"a = {a}");
                Console.WriteLine($"b = {b}");
                Console.WriteLine($"y = {y}");
                Console.ReadLine();
            }
    }
}

