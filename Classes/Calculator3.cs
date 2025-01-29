using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
        public class Calculator3
        {
            public double _x;
            public double _p;

            public Calculator3(double x, double p)
            {
                _x = x;
                _p = p;
            }
            public double CalculateA()
            {
                return Math.Exp(Math.Sqrt(Math.Abs(_x)));
            }
            public double CalculateB()
            {
                double a = CalculateA();
                return (Math.Sin(Math.Pow(_p, 2)) + Math.Pow(_x, 3));
            }
            public double CalculateY()
            {
                double a = CalculateA();
                double b = CalculateB();
                return Math.Pow(a, 3) / Math.Pow(b, 3);
            }
            public void DisplayResults3()
            {
                double y = CalculateY();
                double a = CalculateA();
                double b = CalculateB();

                Console.WriteLine($"y = {y}");
                Console.WriteLine($"a = {a}");
                Console.WriteLine($"b = {b}");
                Console.ReadLine();
            }
        }
    }
