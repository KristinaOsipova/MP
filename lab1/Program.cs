using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int a = int.Parse(s); //преобразование строки в число 
            string s1 = Console.ReadLine();
            int b = int.Parse(s1); //преобразование строки в число
            string s2 = Console.ReadLine();
            int d = int.Parse(s2);

            Console.WriteLine("Zadanie_1\n");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            int c = a + b;
            Console.WriteLine(a + "+" + b + "=" + c);

            Console.WriteLine("\nZadanie_2\n");
            Console.WriteLine(a + "+" + b + "=" + b + "+" + a);
           

            Console.WriteLine("\nZadanie_3\n");
            Console.WriteLine(a + "+" + b + "+" + c + "=" + c);

            Console.WriteLine("\nZadanie_4\n");
            string k = Console.ReadLine();
            float e = float.Parse(k); //преобразование строки в число 
            string k1 = Console.ReadLine();
            float g = float.Parse(k1); //преобразование строки в число
            Console.WriteLine("e = " + e);
            Console.WriteLine("g = " + g);
            float j = e * g;
            Console.WriteLine("{0:.#} * {1:.#} = {2:.#}", e, g, j);

            Console.WriteLine("\nZadanie_5\n");
            string f = Console.ReadLine();
            float o = float.Parse(f); //преобразование строки в число 
            string f1 = Console.ReadLine();
            float p = float.Parse(f1); //преобразование строки в число
            Console.WriteLine("o = " + o);
            Console.WriteLine("p = " + p);
            float y = o / p;
            Console.WriteLine("{0:.000} / {1:.000} = {2:0.000}", o, p, y);

            Console.WriteLine("\nZadanie_6\n");
            string z = Console.ReadLine();
            float v = float.Parse(z); //преобразование строки в число 
            string z1 = Console.ReadLine();
            float w = float.Parse(z1); //преобразование строки в число
            string z2 = Console.ReadLine();
            float l = float.Parse(z2); //преобразование строки в число
            Console.WriteLine("v = " + v);
            Console.WriteLine("w = " + w);
            Console.WriteLine("l = " + l);
            Console.WriteLine("({0:.00} + {1:.00}) + {2:.00}= {0:.00}+({1:.00}+{2:.00})", v, w, l);
        }
    }
}
