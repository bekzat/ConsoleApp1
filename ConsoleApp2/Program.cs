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
        static void Sum(int[] array, int i=0, int sumArray = 0)
        {
            if (i >= array.Length)
            {
                Console.WriteLine("\nСумма массива = " + sumArray);
                return;
            }
            sumArray += array[i];
            i++;
            Sum(array, i, sumArray);
        }
        static void numSum(int num, int summa=0, int count=1000000)
        {
            int value = num / count;
            if(value<0)
            {
                count /= 10;
            }else
            {
                summa += value;
                value *= count;
                num -= value;
                count /= 10;
            }
            if (num == 0)
            {
                Console.WriteLine(summa);
                return;
            }

            numSum(num, summa, count);
        }
        static void Main(string[] args)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 100 };
            print(myArray);
            Sum(myArray);
            Console.WriteLine();
            int num = int.Parse(Console.ReadLine());
            numSum(num);
            Console.WriteLine();
        }
    }
}
