using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Test
    /// </summary>
    class Program
    {
        static void Resize(ref int[] array, int newSize)
        {
            int[] newArray = new int[newSize];
            for (int i = 0; i < array.Length && i<newArray.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3 };
            Resize(ref myArray, 10);
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }
        }
    }
}
