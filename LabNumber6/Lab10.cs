using LabNumber6.Extensions;
using LabNumber6.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber6
{
    class Lab10
    {
        private static string buffer = "";
        private static int CAPACITY = 10;

        public static void lab10_main()
        {
            Console.WriteLine("\nLab number 10:\n ");

            causeReverseNumber();

            causeReverseWord();

            causeReverseString();

            causeReverseDoubleNumbers();

            Console.WriteLine();

            int[] arr = new int[CAPACITY];
            ConsoleHandler.fillArray(arr);
            causeReverseArray(arr);

            Console.WriteLine("\nEven index: ");
            arr.evenIndex(); //разширение метода
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("\nOdd index: ");
            arr.oddIndex();

        }

        public static void causeReverseNumber()
        {
            int number = ConsoleHandler.readNumbersFromConsole();
            Console.WriteLine(number.reverse_ExtensionMethod());
        }

        public static void causeReverseWord()
        {
            string word = ConsoleHandler.readStringsFromConsole();
            Console.WriteLine(word.reverse_ExtensionMethod());
        }

        public static void causeReverseString()
        {
            string[] str = ConsoleHandler.readStringsFromConsole().Split(',');
            for (int i = 0; i < str.Length; i++)
            {
                buffer += str[i].reverse_ExtensionMethod();
                buffer += ',';
            }
            buffer = buffer.Remove(buffer.Length - 1);
            Console.WriteLine(buffer);
            buffer = "";
        }

        public static void causeReverseDoubleNumbers()
        {
            double number = ConsoleHandler.readDoubleNumbersFromConsole();
            number.reverse_ExtensionMethod();
        }

        public static void causeReverseArray(int[] array)
        {
            int[] arr = array.reverse_ExtensionMethod();
            ArrayExtension.showArray(array);
        }
     
    }
}
