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
        //Добавить элемент на начало массива
        static void insert(ref int[] array, int value, int index)
        {
            int[] newArray = new int[array.Length + 1];
            
            for (int i = 0, j=0; i < newArray.Length && j<array.Length; i++, j++)
            {
                if(i==index)
                {
                    newArray[index] = value;
                    i++;
                }
                newArray[i] = array[j];
            }
            array = newArray;
        }
        static void print(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static void Main(string[] args)
        {
            int[] myArray = { 3, 5, 9, 6, 2, 4 };
            insert(ref myArray, 314, 3);
            print(myArray);
        }
    }
}
