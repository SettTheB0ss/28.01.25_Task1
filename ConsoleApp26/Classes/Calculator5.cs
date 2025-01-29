using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator5
    {
        public double _t;
        public double _p;

        public Calculator5(double t, double p)
            {
                _t = t;
                _p = p;
            }
            public double CalculateK()
            {
                return Math.Sqrt(_p * _t);
            }
            public double CalculateX()
            {
                double k = CalculateK();
                return _p * Math.Pow(_t, 2) + Math.Sqrt(k);
            }
            public double CalculateY()
            {
                double x = CalculateX();
                double k = CalculateK();
                return Math.Pow(Math.Tan(Math.Pow(x, 2)), 3) + k * _t;
            }
            public void DisplayResults()
            {
                double y = CalculateY();
                double x = CalculateX();
                double k = CalculateK();

                Console.WriteLine($"y = {y}");
                Console.WriteLine($"x = {x}");
                Console.WriteLine($"k = {k}");
                Console.ReadLine();
            }
    }
}

