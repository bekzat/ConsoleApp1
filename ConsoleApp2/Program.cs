using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void print(int[] array, int i=0)
        {
            if (i >= array.Length)
                return;
            Console.Write(array[i]+"\t");
            i++;
            print(array, i);
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            print(myArray);
            Console.WriteLine();
        }
    }
}
