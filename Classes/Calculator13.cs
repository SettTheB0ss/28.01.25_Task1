using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26.Classes
{
    internal class Calculator13
    {
        public double _x;
        public double _a;

        public Calculator13(double x, double a)
            {
                _x = x;
                _a = a;
            }
            public double CalculateW()
            {
                return  Math.Pow(_x, 2) * Math.Sqrt(Math.Abs(_a + _x));
            }
            public double CalculateZ()
            {
                double w = CalculateW();
                return Math.Pow(Math.Cos(_a),2) + Math.Pow(w, 2);
            }
            public double CalculateY()
            {   
                double w = CalculateW();
                double z = CalculateZ();
                return _a * Math.Pow(z, 7) + Math.Pow(Math.Sin(w), 2);
            }
            public void DisplayResults13()
            {
                double w = CalculateW();
                double z = CalculateZ();
                double y = CalculateY();

                Console.WriteLine($"w = {w}");
                Console.WriteLine($"z = {z}");
                Console.WriteLine($"y = {y}");
                Console.ReadLine();
            }
    }
}

