using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator9
    {
        public double _k;
        public double _m;

        public Calculator9(double k, double m)
            {
                _k = k;
                _m = m;
            }
            public double CalculateX()
            {
                return Math.Exp(_m * _k);
            }
            public double CalculateC()
            {
                double x = CalculateX();
                return Math.Pow(Math.Cos(_m), 2) + Math.Pow(_k, 2);
            }
            public double CalculateY()
            {
                double c = CalculateC();
                double x = CalculateX();
                return Math.Pow(Math.Pow(x, 2) + Math.Pow(c, 3), 1/3);
            }
            public void DisplayResults()
            {
                double x = CalculateX();
                double c = CalculateC();
                double y = CalculateY();

                Console.WriteLine($"x = {x}");
                Console.WriteLine($"c = {c}");
                Console.WriteLine($"y = {y}");
                Console.ReadLine();
            }
    }
}

