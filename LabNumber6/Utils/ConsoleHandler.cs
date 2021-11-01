using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber6.Utils
{
    class ConsoleHandler
    {
        public static int readNumbersFromConsole()
        {
            Console.WriteLine("Enter values:");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static string readStringsFromConsole()
        {
            Console.WriteLine("Enter strings:");
            return Console.ReadLine();;
        }

        public static double readDoubleNumbersFromConsole()
        {
            Console.WriteLine("Enter values with point:");
            return Convert.ToDouble(Console.ReadLine());;
        }

        public static void fillArray(int[] array)
        {
            Console.WriteLine("Please fill array: ");
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }



    }
}
