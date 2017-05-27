using System;

namespace Zad2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double d1 = 23.23423;
            double d2 = 3245.3413;
            Console.WriteLine(format: "В методе Main: d1 = {0}\td2 = {1}", arg0: d1, arg1: d2);
            Example.Sqr(d1: ref d1, d2: ref d2);
            Console.WriteLine(format: "В методе Main: d1 = {0}\td2 = {1}", arg0: d1, arg1: d2);
            //Example.Sqr(d1*2,d2*2);
            //Console.WriteLine(format: "В методе Main: d1 = {0}\td2 = {1}", arg0: d1, arg1: d2);
            Example obj = new Example(x: 4);
            Console.WriteLine(value: obj);
            Console.WriteLine(format: "В методе Main: Obj.x = {0}\tObj.y = {1}", arg0: obj.x, arg1: obj.y);
            Example.Init(obj: ref obj);
            Console.WriteLine(format: "В методе Main: Obj.x = {0}\tObj.y = {1}", arg0: obj.x, arg1: obj.y);
            double d3;
            //Example.Sqr(ref d1, ref d3);//{CS0165] Использование локальной переменной "d3", которой не присвоено значение
            Console.ReadLine();
        }
    }
}