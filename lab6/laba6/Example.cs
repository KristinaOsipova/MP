using System;
using System.Security.Cryptography.X509Certificates;

namespace laba6
{
    public class Example
    {
        public int x;
        public int y;

        public Example(int x)
        {
            this.x = x;
        }

        public static void Sqr(double d1, double d2)
        {
            d1 = Math.Pow(d1, 2);
            d2 = Math.Pow(d2, 2);
            Console.WriteLine("В методе Sqr: d1 = {0}\td2 = {1}", d1, d2);
        }
        /*
                public static void Init(Example obj)
                {
                    obj.x = 1;
                    obj.y = 1;
                    Console.WriteLine("В методе Init: x = {0}\ty = {1}",obj.x, obj.y);
                }
        */
        public static void Init(Example obj)
        {
            Example obj2 = new Example(3);
            obj2.x = 1;
            obj2.y = 1;
            obj = obj2;
            Console.WriteLine("В методе Init: x = {0}\ty = {1}", obj.x, obj.y);
        }

        public override String ToString()
        {
            return "x = " + x + "\ty = " + y;
        }
    }
}