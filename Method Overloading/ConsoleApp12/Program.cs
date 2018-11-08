using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int[] array = { 1, 7, 6, 9, 0 };
            int[,] ARRAY = { { 1, 2, 6, 5, 7 }, { 2, 3, 5, 4, 5 }, { 5, 4, 6, 3, 2 } };
            int[][] DIF = { new int[] { 5, 4, 3, 7, 5 }, new int[] { 2, 7 }, new int[] { 7, 4, 6 } };

            Print(a);
            Console.WriteLine();
            Console.WriteLine();

            Print(array);
            Console.WriteLine();
            Console.WriteLine();

            Print(ARRAY);
            Console.WriteLine();
            Console.WriteLine();

            Print(DIF);
            Console.WriteLine();
            Console.WriteLine();

            Console.ReadLine();
        }

        public static void Print(int a)
        {
            Console.WriteLine("Int" + a);
        }

        public static void Print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("|" + array[i] + "|");
            }
        }

        public static void Print(int[,] ARRAY)
        {
            for (int i = 0; i < ARRAY.GetLength(0); i++)
            {
                for (int j = 0; j < ARRAY.GetLength(1); j++)
                {
                    Console.Write("|" + ARRAY[i,j] + "|");
                }
                Console.WriteLine();
            }
        }

        public static void Print(int[][] DIF)
        {
            for (int i = 0; i < DIF.Length; i++)
            {
                for (int j = 0; j < DIF[i].Length; j++)
                {
                    Console.Write("|" + DIF[i][j] + "|");
                }
                Console.WriteLine();
            }
        }
    }
}
