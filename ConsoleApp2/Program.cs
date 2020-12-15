using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void printArray(int[] array, int i = 0)
        {
            if(i<array.Length)
            {
                Console.WriteLine(array[i]);
                printArray(array, i + 1);
            }
            return;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            printArray(myArray);
        }
    }
}
