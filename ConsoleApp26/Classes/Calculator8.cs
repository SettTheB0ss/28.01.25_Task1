using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator8
    {
        public double _b;
        public double _c;

        public Calculator8(double b, double c)
            {
                _b = b;
                _c = c;
            }
            public double CalculateA()
            {
            return Math.Sin(_b);
            }
            public double CalculateX()
            {
                double a = CalculateA();
                return a + Math.Pow((_b + _c), 3);
            }
            public double CalculateY()
            {
                double a = CalculateA();
                double x = CalculateX();
                return 7 * Math.Exp(Math.Sqrt(Math.Abs(x)) + Math.Pow(Math.Sqrt(x), 4));
            }
            public void DisplayResults()
            {
                double a = CalculateA();
                double x = CalculateX();
                double y = CalculateY();

                Console.WriteLine($"y = {y}");
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"a = {a}");
                Console.ReadLine();
            }
    }
}

