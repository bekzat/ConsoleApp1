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
        /// <summary>
        /// Возвращет сумму двух чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            int d = a + b;
            return d;
        }
        /// <summary>
        /// Возвращет сумму трех чисел
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        static int Sum(int a, int b, int c)
        {
            int d = a + b + c;
            return d;
        }
        static void Main(string[] args)
        {
            int result = Sum(3, 5);
            Console.WriteLine(result);
        }
    }
}
