using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Задание 2.1
            //Console.WriteLine("n= ");
            //int n = int.Parse(Console.ReadLine());
            //if (n % 2 == 0) Console.WriteLine("Количество черных клеток для четных = " + n * n / 2);
            //else
            //{
            //    double a;
            //    a = (double)n;
            //    Console.WriteLine("Количество черных клеток для нечетных = " + a * a / 2 + 0.5);
            //}

            //Console.WriteLine("\n k=");
            //int k = int.Parse(Console.ReadLine());
            //Console.WriteLine("m=");
            //int m = int.Parse(Console.ReadLine());
            //if (k % 2 != 0 && m % 2 != 0) Console.WriteLine("Черная");
            //if (k % 2 != 0 && m % 2 == 0) Console.WriteLine("Белая");
            //if (k % 2 == 0 && m % 2 != 0) Console.WriteLine("Белая");
            //if (k % 2 == 0 && m % 2 == 0) Console.WriteLine("Черная");




            //Console.WriteLine("\n k1=");
            //int k1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("m1=");
            //int m1 = int.Parse(Console.ReadLine());
            //string s = "Черная";
            //if (k1 % 2 != 0 && m1 % 2 != 0) s = "Черная";
            //if (k1 % 2 != 0 && m1 % 2 == 0) s = "Белая";
            //if (k1 % 2 == 0 && m1 % 2 != 0) s = "Белая";
            //if (k1 % 2 == 0 && m1 % 2 == 0) s = "Черная";
            //Console.WriteLine("k2=");
            //int k = int.Parse(Console.ReadLine());
            //Console.WriteLine("m2=");
            //int m = int.Parse(Console.ReadLine());
            //string s2 = "Черная";
            //if (k % 2 != 0 && m % 2 != 0) s2 = "Черная";
            //if (k % 2 != 0 && m % 2 == 0) s2 = "Белая";
            //if (k % 2 == 0 && m % 2 != 0) s2 = "Белая";
            //if (k % 2 == 0 && m % 2 == 0) s2 = "Черная";
            //if (s == s2) Console.WriteLine("Ячейки одного цвета");
            //else Console.WriteLine("Ячейки разного цвета");


            //Console.WriteLine("k1=");
            //int k1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("m1=");
            //int m1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("k2=");
            //int k2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("m2=");
            //int m2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("фигура ");
            //string figure = Console.ReadLine();
            //switch (figure)
            //{
            //    case "пешка":
            //        {
            //            if (m2 == m1 + 1 && (k2 == k1 + 1 || k2 == k1 - 1)) Console.WriteLine("Под ударом");
            //            else Console.WriteLine("Не попадает под удар");
            //        }
            //        break;
            //    case "конь":
            //        {
            //            if (m2 == m1 + 2 && (k2 == k1 - 1 || k2 == k1 + 1)) Console.WriteLine("Под ударом");
            //            else if (m2 == m1 + 1 && (k2 == k1 - 2 || k2 == k1 + 2)) Console.WriteLine("Под ударом");
            //            else if (m2 == m1 - 2 && (k2 == k1 - 1 || k2 == k1 + 1)) Console.WriteLine("Под ударом");
            //            else if (m2 == m1 - 1 && (k2 == k2 - 2 || k2 == k2 + 2)) Console.WriteLine("Под ударом");
            //            else Console.WriteLine("Не попадает под удар");
            //        }
            //        break;
            //    case "ладья":
            //        {
            //            if (k1 == k2 || m1 == m2) Console.WriteLine("Под ударом");
            //            else Console.WriteLine("Не попадает под удар");
            //        }
            //        break;
            //    case "слон":
            //        {
            //            if (m2 - m1 == k2 - k1 || m1 - m2 == k2 - k1) Console.WriteLine("Под ударом");

            //            else if (m2 - m1 == k1 - k2 || m1 - m2 == k1 - k2) Console.WriteLine("Под ударом");
            //            else Console.WriteLine("Не попадает под удар");
            //        }
            //        break;

            //    case "ферзь":
            //        {
            //            int a = k2 - k1;
            //            int b = k1 - k2;
            //            if (m2 - m1 == a || m1 - m2 == a) Console.WriteLine("Под ударом");

            //            else if (m2 - m1 == b || m1 - m2 == b) Console.WriteLine("Под ударом");
            //            else if (k1 == k2 || m1 == m2) Console.WriteLine("Под ударом");
            //            else Console.WriteLine("Не попадает под удар");
            //        }
            //        break;

            //}


            ////Задание 2.2
            //DateTime d1 = new DateTime(2017, 03, 06);
            //DateTime d2 = new DateTime(2017, 01, 01);
            //DateTime d3 = new DateTime(2017, 12, 31);
            //int days1 = (d1 - d2).Days;
            //int days2 = (d3 - d1).Days;
            //Console.WriteLine("\n\n С начало года прошло " + days1 + " дней");
            //Console.WriteLine("До конца года " + days2 + " дней");
            //DateTime day = d1.AddDays(-1);
            //Console.WriteLine("Вчера было " + day.ToShortDateString());
            //DateTime day1 = d1.AddDays(+1);
            //Console.WriteLine("Завтра будет " + day1.ToShortDateString());


            //Задание 2.3
            //for (int i = 100; i < 999; i++)
            //{
            //    for (int n = 1; n < 10; n++)
            //    {
            //        int a = i / 100;
            //        int b = (i % 100) / 10;
            //        int c = i % 10;

            //        if ((Math.Pow(a, n) + Math.Pow(b, n) + Math.Pow(c, n)) == i)
            //            Console.WriteLine("Числа Армстронга:\n " + i);
            //    }
            //}



            //Задание 2.4
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("m=");
            int m = int.Parse(Console.ReadLine());
            int s = n * m;
            Console.WriteLine("Маленьких квадратов " + s);//a
            int k = 1;
            while (n != m)
            {
                if (n > m) n = n - m;
                else m = m - n;
                k++;
            }
            Console.WriteLine("Больших квадратов " + k);//b

            Console.ReadKey();
        }
    }
}



