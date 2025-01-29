using ConsoleApp26.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Практическая работа №4");
            Console.WriteLine("1-30");
            int sm = Convert.ToInt32(Console.ReadLine());

            double a, b, c, k, m, n, p, q, t, x;


            switch (sm)
            {
                case 1:
                    x = 3.5;
                    b = 0.4;

                    Calculator1 calculator1 = new Calculator1(x, b);
                    calculator1.DisplayResults1();
                    break;

                case 2:
                    x = 1.3;
                    k = 4;

                    Calculator2 calculator2 = new Calculator2(x, k);
                    calculator2.DisplayResults2();
                    break;

               case 3:
                    x = 2.1;
                    p = 1;

                    Calculator3 calculator3 = new Calculator3(x, p);
                    calculator3.DisplayResults3();
                    break;

                case 4:
                    x = 2.7;
                    t = -6;

                    Calculator4 calculator4 = new Calculator4(x, t);
                    calculator4.DisplayResults4();
                    break;

                case 5:
                    t = 4.1;
                    p = 3;

                    Calculator5 calculator5 = new Calculator5(t, p);
                    calculator5.DisplayResults5();
                    break;

                case 6:
                    m = 2;
                    x = 1.1;

                    Calculator6 calculator6 = new Calculator6(m, x);
                    calculator6.DisplayResults6();
                    break;

                case 7:
                    k = 8.2;
                    x = 5;

                    Calculator7 calculator7 = new Calculator7(k, x);
                    calculator7.DisplayResults7();
                    break;

                case 8:
                    b = 2.2;
                    c = 3.7;

                    Calculator8 calculator8 = new Calculator8(b, c);
                    calculator8.DisplayResults8();
                    break;

                case 9:
                    k = 1;
                    m = 1.8;

                    Calculator9 calculator9 = new Calculator9(k, m);
                    calculator9.DisplayResults9();
                    break;

                case 10:
                    x = 2.8;
                    b = 1.3;

                    Calculator10 calculator10 = new Calculator10(x, b);
                    calculator10.DisplayResults10();
                    break;

                case 11:
                    b = 7;
                    x = 2;

                    Calculator11 calculator11 = new Calculator11(b, x);
                    calculator11.DisplayResults11();
                    break;

                case 12:
                    q = 2;
                    b = 1.8;

                    Calculator12 calculator12 = new Calculator12(q, b);
                    calculator12.DisplayResults12();
                    break;

                case 13:
                    x = 1.9;
                    a = -0.9;

                    Calculator13 calculator13 = new Calculator13(x, a);
                    calculator13.DisplayResults13();
                    break;

                case 14:
                    b = 6;
                    k = 3.4;

                    Calculator14 calculator14 = new Calculator14(b, k);
                    calculator14.DisplayResults14();
                    break;

                case 15:
                    a = 5.5;
                    p = 4;

                    Calculator15 calculator15 = new Calculator15(a, p);
                    calculator15.DisplayResults15();
                    break;

                case 16:
                    x = 8.52;
                    c = 9;

                    Calculator16 calculator16 = new Calculator16(x, c);
                    calculator16.DisplayResults16();
                    break;

                case 17:
                    x = 0.9;
                    t = 2;

                    Calculator17 calculator17 = new Calculator17(x, t);
                    calculator17.DisplayResults17();
                    break;

                case 18:
                    x = -8;
                    b = 9.5;

                    Calculator18 calculator18 = new Calculator18(x, b);
                    calculator18.DisplayResults18();
                    break;

                case 19:
                    x = 4;
                    a = 3.7;

                    Calculator19 calculator19 = new Calculator19(x, a);
                    calculator19.DisplayResults19();
                    break;

                case 20:
                    x = 1.4;
                    p = 1.6;

                    Calculator20 calculator20 = new Calculator20(x, p);
                    calculator20.DisplayResults20();
                    break;

                case 21:
                    n = 8.1;
                    b = 1.6;

                    Calculator21 calculator21 = new Calculator21(n, b);
                    calculator21.DisplayResults21();
                    break;

                case 22:
                    m = 5.7;
                    p = 4;

                    Calculator22 calculator22 = new Calculator22(m, p);
                    calculator22.DisplayResults22();
                    break;

                case 23:
                    b = 0.3;
                    x = 5.2;

                    Calculator23 calculator23 = new Calculator23(b, x);
                    calculator23.DisplayResults23();
                    break;

                case 24:
                    t = 6.2;
                    b = 1.8;

                    Calculator24 calculator24 = new Calculator24(t, b);
                    calculator24.DisplayResults24();
                    break;

                case 25:
                    a = 2;
                    p = 2.6;

                    Calculator25 calculator25 = new Calculator25(a, p);
                    calculator25.DisplayResults25();
                    break;

                case 26:
                    b = 8.1;
                    t = 2;

                    Calculator26 calculator26 = new Calculator26(b, t);
                    calculator26.DisplayResults26();
                    break;

                case 27:
                    t = -3;
                    a = 76;

                    Calculator27 calculator27 = new Calculator27(t, a);
                    calculator27.DisplayResults27();
                    break;

                case 28:
                    b = 2.19;
                    k = 1.7;

                    Calculator28 calculator28 = new Calculator28(b, k);
                    calculator28.DisplayResults28();
                    break;

                case 29:
                    a = 6;
                    b = 4.3;

                    Calculator29 calculator29 = new Calculator29(a, b);
                    calculator29.DisplayResults29();
                    break;

                case 30:
                    t = 3;
                    b = 4.2;

                    Calculator30 calculator30 = new Calculator30(t, b);
                    calculator30.DisplayResults30();
                    break;
            }
        }
    }
}
