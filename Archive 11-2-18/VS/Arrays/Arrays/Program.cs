using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        private const int MaxValue = 100000000;

        static void Main(string[] args)
        {
            int[] myIntArray = new int[10];
            Random rand = new Random();


            Console.WriteLine("Array: ");
            for (int i = 0; i < myIntArray.Length; i++)
            {
                myIntArray[i] = rand.Next(0, MaxValue);
                Console.Write(myIntArray[i] + ".");
                
            }
            Console.WriteLine();
            Console.WriteLine();

            List<int> myIntList = new List<int>();


            Console.WriteLine("List: ");
            for (int i = 0; i < 10; i++)
            {
                myIntList.Add(rand.Next());
                Console.Write(myIntList[i] + ".");
              
            }
            Console.WriteLine();
        }
    }
}
