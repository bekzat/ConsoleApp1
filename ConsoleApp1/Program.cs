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
        static void print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void addItem(ref int[] array, int item)
        {
            int[] newArray = new int[array.Length + 1];
            newArray[0] = item;
            for (int i = 1; i < newArray.Length; i++)
            {
                newArray[i] = array[i-1];
            }
            array = newArray;
        }
        static void Main(string[] args)
        {
            int[] myArray = { 2, 3, 4 };
            addItem(ref myArray, 5);
            print(myArray);
        }
    }
}
