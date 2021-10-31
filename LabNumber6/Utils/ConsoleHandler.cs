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
            int numbers = Convert.ToInt32(Console.ReadLine());
            return numbers;
        }

        public static string readStringsFromConsole()
        {
            Console.WriteLine("Enter strings:");
            string words = Console.ReadLine();
            return words;
        }

        public static double readDoubleNumbersFromConsole()
        {
            Console.WriteLine("Enter values:");
            double numbers = Convert.ToDouble(Console.ReadLine());
            return numbers;
        }

        public static void fillArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }



    }
}
