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
            causeReverseNumber();
            Console.WriteLine();
            //Reverse word
            causeReverseWord();
            //Reverse strings
            causeReverseString();
            //Reverse number with point
            causeReverseDoubleNumbers();
            //Reverse array
            int[] array = new int[CAPACITY];
            causeReverseArray(array);

            Lab10.lab10_main();

            Console.Read();
        }

        public static void causeReverseNumber()
        {
            ReverseManager.reverse(ConsoleHandler.readNumbersFromConsole());
        }

        public static void causeReverseWord()
        {
            ReverseManager.reverse(ConsoleHandler.readStringsFromConsole(), out buffer);
            Console.WriteLine(buffer);
        }

        public static void causeReverseString()
        {
            string[] words = ConsoleHandler.readStringsFromConsole().Split(',');
            string result = "";
            buffer = "";

            for (int i = 0; i < words.Length; i++)
            {
                ReverseManager.reverse(words[i], out buffer);
                result += buffer + ",";
            }
            result = result.Remove(result.Length - 1);
            Console.WriteLine(result);
        }

        public static void causeReverseDoubleNumbers()
        {
            double number = ConsoleHandler.readDoubleNumbersFromConsole();
            string numberStr = number.ToString();
            string[] arrNumbers = numberStr.Split(',','.');
            string result = "";

            for (int i = 0; i < arrNumbers.Length; i++)
            {
                ReverseManager.reverse(arrNumbers[i], out buffer);
                result += buffer + '.';
            }
            result = result.Remove(result.Length - 1);
            Console.WriteLine(result);
        }

        public static void causeReverseArray(int[] array)
        {
            int[] result;
            ConsoleHandler.fillArray(array);
            ReverseManager.reverse(ref array, out result);
            ArrayExtension.showArray(result);
        }
     
    }
}
