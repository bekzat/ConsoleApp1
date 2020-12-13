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
        static void Foo(params object[] parameters)
        {
            string message = "Типы данных {0}, значение {1}";

            foreach (var item in parameters)
            {
                Console.WriteLine(message, item.GetType(), item);
            }
        }
        static void Main(string[] args)
        {
            Foo("test", 5, 'q', 5.49f, true);
        }
    }
}
