using System;
using System.Collections.Generic;

namespace Zad3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(info(13));
            Console.WriteLine(info(-2.3));
            Console.WriteLine(info(new Random().NextDouble()));
            Console.ReadLine();
        }

        public static String info(double d)
        {
            String str = "Число " + d + " - ";
            if (d > 0)
            {
                str = str + "положительное, ";
            }
            else
            {
                str = str + "отрицательное, ";
            }
            if (d % 1 == 0)
            {
                str = str + "целое, ";
            }
            else
            {
                str = str + "вещественное, ";
            }
            str = str + "модуль числа - " + Math.Abs(d) + ", квадрат числа - " + Math.Pow(d, 2);
            return str;
        }
    }
}