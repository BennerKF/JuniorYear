using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            int Answer = 0;
            String Instruct = "Press Enter Key Once To Clear Shape.";
            while (Answer != 33) 
            {
                Console.Clear();
                Console.WriteLine("*********ASCII ART********");
                Console.WriteLine(" 1 - Small Square");
                Console.WriteLine(" 2 - 3x3 Square");
                Console.WriteLine(" 3 - 5x4 Square");
                Console.WriteLine(" 4 - Leftward Triangle");
                Console.WriteLine(" 5 - Rightward Triangle");
                Console.WriteLine(" 6 - \\ Through Square");
                Console.WriteLine(" 7 - / Through Square");
                Console.WriteLine(" 8 - X Through Square");
                Console.WriteLine(" 9 - Pyramid Shape");
                Console.WriteLine(" 33 - Exit Menu");
                Console.WriteLine("**************************");
                Console.Write("Enter Number: ");
                Answer = int.Parse(Console.ReadLine());
                Console.WriteLine();


                switch (Answer)
                {
                    case 1:
                        //Small Square
                        Console.WriteLine("X");
                        Console.WriteLine();
                        Console.WriteLine(Instruct);
                        Console.ReadKey();
                   break;

                   case 2:
                        //3x3 Square
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 3; j++)
                            {
                               Console.Write("X");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine(Instruct);
                        Console.ReadKey();
                   break;

                   case 3:
                        //5 x 4 Square
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                Console.Write("X");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine(Instruct);
                        Console.ReadKey();
                   break;

                   case 4:
                        //Leftward Triangle
                        for (int i = 0; i < 6; i++)
                        {
                            for (int j = 0; j < i; j++)
                            {
                                Console.Write("X");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine(Instruct);
                        Console.ReadKey();
                   break;

                   case 5:
                        //Rightward triangle
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (3 - j >= i)
                                    Console.Write(" ");
                                else
                                    Console.Write("X");


                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine(Instruct);
                        Console.ReadKey();
                   break;

                   case 6:
                        // \ through Square
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (j == i)
                                    Console.Write(" ");
                                else
                                    Console.Write("X");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine(Instruct);
                        Console.ReadKey();
                   break;

                   case 7:
                        // / through square
                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (4 - j == i)
                                    Console.Write(" ");
                                else
                                    Console.Write("X");


                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine(Instruct);
                        Console.ReadKey();
                   break;

                   case 8:
                        //Double lines through square

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = 0; j < 5; j++)
                            {
                                if (4 - j == i || j == i)
                                    Console.Write(" ");
                                else
                                    Console.Write("X");


                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine(Instruct);
                        Console.ReadKey();
                   break;

                   case 9:
                        //Pyramid
                        int m = 3 / 2 + 1;
                        for (int i = 0; i < 3; i++)
                        {
                            for (int j = 0; j < 7; j++)
                            {
                                if (j >= m - i && j <= m + i)
                                        Console.Write("X");
                                else
                                    Console.Write(" ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine();
                        Console.WriteLine(Instruct);
                        Console.ReadKey();
                   break;
               
                }
            }
            Console.WriteLine("GOODBYE =)");
            Console.WriteLine();
        }
    }
}
