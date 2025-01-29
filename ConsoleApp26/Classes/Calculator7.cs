using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator7
    {
        public double _x;
        public double _k;

        public Calculator7(double x, double k)
            {
                _x = x;
                _k = k;
            }
            public double CalculateC()
            {
                return Math.Sqrt(Math.Abs(_x));
            }
            public double CalculateA()
            {
                double c = CalculateC();
                return Math.Pow(c, 4) + Math.Pow(_k, 3);
            }
            public double CalculateY()
            {
                double a = CalculateA();
                return Math.Pow(Math.Log10(a), 3) + Math.Pow(Math.Cos(_x),5);
            }
            public void DisplayResults()
            {
                double y = CalculateY();
                double a = CalculateA();
                double c = CalculateC();

                Console.WriteLine($"y = {y}");
                Console.WriteLine($"a = {a}");
                Console.WriteLine($"c = {c}");
                Console.ReadLine();
            }
    }
}

