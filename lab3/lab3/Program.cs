﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class arrs
    {
        static Random rnd = new Random();
        public static void CreateOneDimAr(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-50, 50);
            }
        }
        public static void CreateAr2(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    arr[i, j] = rnd.Next(-50, 50);
                }
            }
        }
        public static void CreateAr3(int[][] arr)
        {
           for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[i + 1];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rnd.Next(-50, 50);
                }
            }
        }

        public static void CreateAr3Rnd(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[rnd.Next(2, 7)];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = rnd.Next(-50, 50);
                }
            }
        }

        public static void PrintArr3(string str, int[][] arr)
        {
            Console.WriteLine($"{str}");
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("{0, 5}", arr[i][j]);
                }
                Console.WriteLine();
            }
        }
        public static void PrintArr1(string str, int[] arr)
        {
            Console.WriteLine($"{str}");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        public static int[,] MultMatr(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
            int[,] arr = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        arr[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return arr;
        }
        public static void PrintArr2(string str, int[,] a)
        {
            Console.WriteLine($"{str}");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Задание 1\n");
            int[] A = new int[5],
                  B = new int[5],
                  C = new int[5];

            arrs.CreateOneDimAr(A);
            arrs.CreateOneDimAr(B);
            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i] + B[i];
            }

            int[] X = { 5, 5, 6, 6, 7, 7 };
            int[] U, V;
            U = new int[3] { 1, 2, 3 };
            V = new int[3];
            V = U;
            V[1] = 9;
            arrs.PrintArr1("A", A);
            arrs.PrintArr1("B", B);
            arrs.PrintArr1("C", C);
            arrs.PrintArr1("U", U);
            arrs.PrintArr1("V", V);
            Console.WriteLine($"(-_-)***************************************(^_^)\n\n");

            Console.WriteLine($"Задание 2\n");
            int[,] matrix1 = new int[3, 3],
                   matrix2 = new int[3, 3];
            arrs.CreateAr2(matrix1);
            arrs.PrintArr2("matrix1", matrix1);
            arrs.CreateAr2(matrix2);
            arrs.PrintArr2("matrix2", matrix2);
            int[,] matrix3 = arrs.MultMatr(matrix1, matrix2);
            arrs.PrintArr2("matrix3", matrix3);
            Console.WriteLine($"(-_-)***************************************(^_^)\n\n");

            Console.WriteLine($"Задание 3\n");
            int[][] mass = new int[6][];
            arrs.CreateAr3Rnd(mass);
            arrs.PrintArr3("MassMass", mass);
            int[][] R = new int[10][];
            arrs.CreateAr3(R);
            arrs.PrintArr3("R", R);
            Console.ReadKey();
        }
    }
}