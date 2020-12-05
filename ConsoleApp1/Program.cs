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
        static int[] fillInArray(int[] newArray)
        {
            Random rnd = new Random();
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = rnd.Next(100, 999);
            }
            return newArray;
        }
        static void printArray(int[] newArray)
        {
            Console.WriteLine("массив:");
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i]+"\t");
            }
            Console.WriteLine();
        }
        //HW 1
        static int[] Resize(ref int[] newArray)
        {
            Console.Write("Размер массива: ");
            int amount = int.Parse(Console.ReadLine());
            newArray = new int[amount];
            return newArray;
        }

        //HW 2
        static ref int addFirstItem(int[] newArray)
        {
            return ref newArray[0];
        }
        static ref int addLastItem(int[] newArray)
        {
            return ref newArray[newArray.Length - 1];
        }
        static ref int addItem(int[] newArray)
        {
            Console.Write("Элемент под индексом: ");
            int index = int.Parse(Console.ReadLine());
            return ref newArray[index];
        }

        //HW 3
        static ref int delFirstItem(int[] newArray)
        {
            return ref newArray[0];
        }
        static ref int delLastItem(int[] newArray)
        {
            return ref newArray[newArray.Length-1];
        }
        static ref int delItem(int[] newArray)
        {
            Console.Write("\nУдаление элемента под индексом: ");
            int index = int.Parse(Console.ReadLine());
            return ref newArray[index];
        }
        static void Main(string[] args)
        {
            int[] myArray = new int[0];
            Resize(ref myArray);
            fillInArray(myArray);
            Console.WriteLine("Количество элементов массива = " + myArray.Length);
            ref int firstItem = ref addFirstItem(myArray);
            Console.Write("Изменить первый элемент: ");
            firstItem = int.Parse(Console.ReadLine());
            ref int lastItem = ref addLastItem(myArray);
            Console.Write("Изменить последний элемент: ");
            lastItem = int.Parse(Console.ReadLine());
            ref int yourItem = ref addItem(myArray);
            Console.Write("Изменить на: ");
            yourItem = int.Parse(Console.ReadLine());
            printArray(myArray);
            Console.WriteLine();
            ref int deleteFirstItem = ref delFirstItem(myArray);
            Console.Write("\nУдаление первого элемента...");
            deleteFirstItem = 0;
            ref int deleteLastItem = ref delLastItem(myArray);
            Console.Write("\nУдаление последнего элемента...");
            deleteLastItem = 0;
            ref int deleteYourItem = ref delItem(myArray);
            Console.Write("\nУдаление элемента...");
            deleteYourItem = 0;
            printArray(myArray);
        }
    }
}
