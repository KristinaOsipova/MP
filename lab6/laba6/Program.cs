using System;
using System.Collections.Generic;

namespace laba6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double d1 = 23.23423;
            double d2 = 3245.3413;
            Console.WriteLine("В методе Main: d1 = {0}\td2 = {1}", d1, d2);
            Example.Sqr(d1, d2);
            Console.WriteLine("В методе Main: d1 = {0}\td2 = {1}", d1, d2);
            Example.Sqr(d1 * 2, d2 * 2);
            Console.WriteLine("В методе Main: d1 = {0}\td2 = {1}", d1, d2);
            Example obj = new Example(4);
            Console.WriteLine(obj);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", obj.x, obj.y);
            Example.Init(obj);
            Console.WriteLine("В методе Main: Obj.x = {0}\tObj.y = {1}", obj.x, obj.y);
            Console.ReadLine();
        }
    }
}