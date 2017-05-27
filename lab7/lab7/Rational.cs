using System;
using System.CodeDom;
using System.Data.Common;

namespace lab7
{
    public class Rational
    {
        private int m;
        private int n;
        private static readonly int ZERO;
        private static readonly int ONE;

        public static int maxZnam(Rational r1, Rational r2)
        {
            return r1.n * r2.n;
        }

        static Rational()
        {
            ZERO = 0;
            ONE = 1;
        }

        public Rational(int newM, int newN)
        {
            if (newN == 0)
            {
                m = 0;
                n = 1;
            }
            else
            {
                n = newN;
                m = newM;
            }
        }

        private Rational(int a, int b, string t)
        {
            m = a;
            n = b;
        }

        public override String ToString()
        {
            return m + "/" + n;
        }

        public void PrintRational()
        {
            Console.WriteLine(this);
        }

        public static Rational Plus(Rational a, Rational b)
        {
            return new Rational(a.m * b.n + b.m * a.n, maxZnam(a, b));
        }

        public static Rational operator +(Rational r1, Rational r2)
        {
            return Plus(r1, r2);
        }

        public static Rational Minus(Rational a, Rational b)
        {
            int zn = maxZnam(a, b);
            return new Rational(a.m / a.n * zn - b.m / b.n * zn, zn);
        }

        public static Rational operator -(Rational a, Rational b)
        {
            return Minus(a, b);
        }

        public static Rational Mult(Rational a, Rational b)
        {
            return new Rational(a.m * b.m, b.n * a.n);
        }

        public static Rational operator *(Rational a, Rational b)
        {
            return Mult(a, b);
        }

        public static Rational Divide(Rational a, Rational b)
        {
            return new Rational(a.m * b.n, a.n * b.m);
        }

        public static Rational operator /(Rational a, Rational b)
        {
            return Divide(a, b);
        }

        public static bool operator ==(Rational a, Rational b)
        {
            return a.m / a.n == b.m / b.n;
        }

        public static bool operator !=(Rational a, Rational b)
        {
            return !(a == b);
        }

        public static bool operator >(Rational a, Rational b)
        {
            return a.m * 1.0 / a.n > b.m * 1.0 / b.n;
        }

        public static bool operator <(Rational a, Rational b)
        {
            return a.m / a.n < b.m / b.n;
        }

        public static bool operator >(Rational a, double b)
        {
            return a.m * 1.0 / a.n > b;
        }

        public static bool operator <(Rational a, double b)
        {
            return a.m * 1.0 / a.n < b;
        }

        public static bool operator >(double b, Rational a)
        {
            return a.m * 1.0 / a.n > b;
        }

        public static bool operator <(double b, Rational a)
        {
            return a.m * 1.0 / a.n < b;
        }

        public static void TestRational()
        {
            Rational r1 = new Rational(1, 2);
            Rational r2 = new Rational(2, 4);
            Rational r3 = new Rational(0, 2);
            Rational r4 = new Rational(45, 0);
            Console.WriteLine(r4 == r3);
            Console.WriteLine(r1 == r2);
            Console.WriteLine(r1 > r3);
            Console.WriteLine(r1 < r3);
            Console.WriteLine(r1 + r2);
            Console.WriteLine(r1 / r2);
            Console.WriteLine(r1 - r2);
            Console.WriteLine(r1 * r2);
            Console.WriteLine(r1 * r3);
        }
    }
}