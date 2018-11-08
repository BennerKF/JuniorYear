using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace awinsor_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Tic-Tac-Toe");
            char[,] array = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = ' ';
                }
            }

            DrawBoard(array);

            char result;
            do
            {
                ProccessTurn(array, 'X');
                result = VerifyBoard(array);
                Console.Clear();
                DrawBoard(array);


                //check to see if result is special

                ProccessTurn(array, 'O');
                result = VerifyBoard(array);
                Console.Clear();
                DrawBoard(array);

                //check to see if result is special
            } while (result == ' ');
            if (result == 'O' || result == 'X')
                Console.WriteLine("\n\n\n" + result + " WINS !!!");
            if (result == ' ')
                Console.WriteLine("\n\n\nNo One Wins.");
            Console.ReadLine();
        }
        public static void DrawBoard(char[,] array)
        {

            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("|" + array[i, j] + " ");
                }
                Console.WriteLine("|");
            }
        }
        public static char VerifyBoard(char[,] array)
        {

            //checks for X's
            if (array[0, 0] == 'X' && array[0, 1] == 'X' && array[0, 2] == 'X')
            { return 'X'; }
            if (array[1, 0] == 'X' && array[1, 1] == 'X' && array[1, 2] == 'X')
            { return 'X'; }
            if (array[2, 0] == 'X' && array[2, 1] == 'X' && array[2, 2] == 'X')
            { return 'X'; }
            if (array[0, 0] == 'X' && array[1, 0] == 'X' && array[2, 0] == 'X')
            { return 'X'; }
            if (array[0, 1] == 'X' && array[1, 1] == 'X' && array[2, 1] == 'X')
            { return 'X'; }
            if (array[0, 2] == 'X' && array[1, 2] == 'X' && array[2, 2] == 'X')
            { return 'X'; }
            if (array[0, 0] == 'X' && array[1, 1] == 'X' && array[2, 2] == 'X')
            { return 'X'; }
            if (array[2, 0] == 'X' && array[1, 1] == 'X' && array[0, 2] == 'X')
            { return 'X'; }

            //checks for O's
            if (array[0, 0] == 'O' && array[0, 1] == 'O' && array[0, 2] == 'O')
            { return 'O'; }
            if (array[1, 0] == 'O' && array[1, 1] == 'O' && array[1, 2] == 'O')
            { return 'O'; }
            if (array[2, 0] == 'O' && array[2, 1] == 'O' && array[2, 2] == 'O')
            { return 'O'; }
            if (array[0, 0] == 'O' && array[1, 0] == 'O' && array[2, 0] == 'O')
            { return 'O'; }
            if (array[0, 1] == 'O' && array[1, 1] == 'O' && array[2, 1] == 'O')
            { return 'O'; }
            if (array[0, 2] == 'O' && array[1, 2] == 'O' && array[2, 2] == 'O')
            { return 'O'; }
            if (array[0, 0] == 'O' && array[1, 1] == 'O' && array[2, 2] == 'O')
            { return 'O'; }
            if (array[2, 0] == 'O' && array[1, 1] == 'O' && array[0, 2] == 'O')
            { return 'O'; }
            return ' ';

        }
        public static void ProccessTurn(char[,] array, char player)
        {
            do
            {
                Console.WriteLine("Coordinate Key");
                Console.WriteLine("|0,0|0,1|0,2|");
                Console.WriteLine("|1,1|1,2|1,3|");
                Console.WriteLine("|2,1|2,2|2,3|");
                Console.WriteLine();

                Console.WriteLine(player + " Your Turn, Enter Coordinates");
                Console.Write("Enter X Coordinate: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter Y Coordinate: ");
                int y = int.Parse(Console.ReadLine());

                if (array[x, y] == ' ')
                {
                    array[x, y] = player;
                    break;
                }
            } while (true);
        }
    }
}