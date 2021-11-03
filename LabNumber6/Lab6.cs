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
            string[] numbersStr = ConsoleHandler.readDoubleNumbersFromConsole().ToString().Split('.');
            string result = "";
            buffer = "";

            for (int i = 0; i < numbersStr.Length; i++)
            {
                ReverseManager.reverse(numbersStr[i], out buffer);
                result += buffer + ".";
            }

            result = result.Remove(result.Length - 1);
            Console.WriteLine(double.Parse(result));
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
