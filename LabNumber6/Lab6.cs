using LabNumber6.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber6
{
    class Lab6
    {
        private const int CAPACITY = 10;
        private static string buffer = "";

        static void Main(string[] args)
        { 
            //Reverse number
            СauseReverseNumber();
            Console.WriteLine();
            //Reverse word
            СauseReverseWord();
            //Reverse strings
            СauseReverseString();
            //Reverse number with point
            СauseReverseDoubleNumbers();
            //Reverse array
            int[] array = new int[CAPACITY];
            СauseReverseArray(array);

            Lab10.lab10_main();

            Console.Read();
        }

        public static void СauseReverseNumber()
        {
            ReverseManager.Reverse(ConsoleHandler.ReadNumbersFromConsole());
        }

        public static void СauseReverseWord()
        {
            ReverseManager.Reverse(ConsoleHandler.ReadStringsFromConsole(), out buffer);
            Console.WriteLine(buffer);
        }

        public static void СauseReverseString()
        {
            string[] words = ConsoleHandler.ReadStringsFromConsole().Split(',');
            string result = "";
            buffer = "";

            for (int i = 0; i < words.Length; i++)
            {
                ReverseManager.Reverse(words[i], out buffer);
                result += buffer + ",";
            }
            result = result.Remove(result.Length - 1);
            Console.WriteLine(result);
        }

        public static void СauseReverseDoubleNumbers()
        {
            double number = ConsoleHandler.ReadDoubleNumbersFromConsole();
            string numberStr = number.ToString();
            string[] arrNumbers = numberStr.Split(',','.');
            string result = "";

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                ReverseManager.Reverse(arrNumbers[i], out buffer);
                result += buffer + '.';
            }
            result = result.Remove(result.Length - 1);
            Console.WriteLine(result);
        }

        public static void СauseReverseArray(int[] array)
        {
            int[] result;
            ConsoleHandler.FillArray(array);
            ReverseManager.Reverse(ref array, out result);
            ArrayExtension.ShowArray(result);
        }
     
    }
}
