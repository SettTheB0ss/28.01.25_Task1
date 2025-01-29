using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator21
    {
        public double _n;
        public double _b;

        public Calculator21(double n, double b)
            {
                _n = n;
                _b = b;
            }
            public double CalculateX()
            {
                return Math.Pow(_n, _b) + Math.Pow(_b, 2);
            }
            public double CalculateA()
            {
                double x = CalculateX();
                return Math.Sin(Math.Pow(x, 2) + Math.Pow(_b, 2));
            }
            public double CalculateY()
            {
                double a = CalculateA();
                return Math.Log10(a) / Math.Log10(Math.Pow(_b, 3));
            }
            public void DisplayResults21()
            {
                double x = CalculateX();
                double a = CalculateA();
                double y = CalculateY();

                Console.WriteLine($"y = {y}");
                Console.WriteLine($"a = {a}");
                Console.WriteLine($"x = {x}");
                Console.ReadLine();
            }
    }
}

