using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator1
    {
        public double _x;
        public double _b;

        public Calculator1(double x, double b) 
        {
            _x = x;
            _b = b;
        }
        public double CalculateA()
        { 
            return Math.Log10(_x); 
        }
        public double CalculateC() 
        {
            double a = CalculateA();
            return Math.Pow(a, 2) + Math.Sqrt(_b * _x);
        }
        public double CalculateY() 
        {
        double c = CalculateC();
            return Math.Exp(2 * _x) + 9.7 * c;
        }
        public void DisplayResults() 
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
