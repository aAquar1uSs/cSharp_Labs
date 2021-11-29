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

            СauseReverseNumber();

            СauseReverseWord();

            СauseReverseString();

            СauseReverseDoubleNumbers();

            Console.WriteLine();

            int[] arr = new int[CAPACITY];
            ConsoleHandler.FillArray(arr);
            СauseReverseArray(arr);

            Console.WriteLine("\nEven index: ");
            causePrintEvenIndexes(arr);
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("\nOdd index: ");
            СausePrintOddIndexes(arr);

        }

        public static void СauseReverseNumber()
        {
            int number = ConsoleHandler.ReadNumbersFromConsole();
            Console.WriteLine(number.Reverse_ExtensionMethod());
        }

        public static void СauseReverseWord()
        {
            string word = ConsoleHandler.ReadStringsFromConsole();
            Console.WriteLine(word.Reverse_ExtensionMethod());
        }

        public static void СauseReverseString()
        {
            string[] str = ConsoleHandler.ReadStringsFromConsole().Split(',');
            for (int i = 0; i < str.Length; i++)
            {
                buffer += str[i].Reverse_ExtensionMethod();
                buffer += ',';
            }
            buffer = buffer.Remove(buffer.Length - 1);
            Console.WriteLine(buffer);
            buffer = "";
        }

        public static void СauseReverseDoubleNumbers()
        {
            double number = ConsoleHandler.ReadDoubleNumbersFromConsole();
            number.Reverse_ExtensionMethod();
        }

        public static void СauseReverseArray(int[] array)
        {
            int[] arr = array.Reverse_ExtensionMethod();
            ArrayExtension.ShowArray(array);
        }

        public static void СausePrintOddIndexes(int[] arr)
        {
            arr.OddIndex();
        }

        public static void causePrintEvenIndexes(int[] arr)
        {
            arr.EvenIndex(); //разширение метода
        }
    }
}
