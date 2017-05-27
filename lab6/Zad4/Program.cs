using System;
using System.Collections.Generic;

namespace Zad4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = { 3, 5, 4, 7 };
            Console.WriteLine("Среднее арифметическое - " + Avarge(arr));
            short z = 1, e = 12;
            byte v = 107;
            Console.WriteLine(Avarge(z, e, v));
            Console.WriteLine(Avarge());
            Console.ReadLine();
        }

        public static double Avarge(params int[] arr)
        {
            double sum = 0;
            foreach (int elem in arr)
            {
                sum += elem;
            }
            return sum / arr.Length;
        }
    }
}