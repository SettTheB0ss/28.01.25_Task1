using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator11
    {
        public double _x;
        public double _b;

        public Calculator11(double x, double b)
            {
                _x = x;
                _b = b;
            }
            public double CalculateA()
            {

            return Math.Pow((_b + _x), 3);
            }
            public double CalculateC()
            {
            
            return Math.Log10(Math.Abs(_b));
            }
            public double CalculateY()
            {
            double a = CalculateA();
            double c = CalculateC();
                return Math.Pow(c, 2) + Math.Sqrt(Math.Abs(a));
            }
            public void DisplayResults11()
            {
                double a = CalculateA();
                double c = CalculateC();
                double y = CalculateY();

                Console.WriteLine($"a = {a}");
                Console.WriteLine($"c = {c}");
                Console.WriteLine($"y = {y}");
                Console.ReadLine();
            }
    }
}

