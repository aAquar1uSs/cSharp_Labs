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
        private static string temp = "";

        static void Main(string[] args)
        { 
            //Reverse number
            commandReverseNumber();
            Console.WriteLine();
            //Reverse word
            commandReverseWord();
            //Reverse strings
            commandReverseString();
            //Reverse number with point
            commandReverseDoubleNumbers();
            //Reverse array
            int[] array = new int[CAPACITY];
            commandReverseArray(array);

            test();

            //Lab 10
            Lab10.lab10_main();

            Console.Read();
        }

        public static void commandReverseNumber()
        {
            ReverseManager.reverse(ConsoleHandler.readNumbersFromConsole());
        }

        public static void commandReverseWord()
        {
            ReverseManager.reverse(ConsoleHandler.readStringsFromConsole(), out temp);
            Console.WriteLine(temp);
        }

        public static void commandReverseString()
        {
            string[] words = ConsoleHandler.readStringsFromConsole().Split(',');
            string result = "";
            temp = "";

            for (int i = 0; i < words.Length; i++)
            {
                ReverseManager.reverse(words[i], out temp);
                result += temp + ",";
            }
            result = result.Remove(result.Length - 1);
            Console.WriteLine(result);
        }

        public static void test()
        {
            double number = ConsoleHandler.readDoubleNumbersFromConsole();
            double iPart = (int)number;
            double dPart = number - iPart;
            double res = 0;

            double res1 = 0, res2 = 0;

            ReverseManager.reverse(iPart, out res);
            res1 = res;
            res = 0;
            ReverseManager.reverse(dPart, out res);
            res2 = res;

            res = res1 + res2;
            Console.WriteLine("TEST=" + res); 
        }

        public static void commandReverseDoubleNumbers()
        {
            double number = ConsoleHandler.readDoubleNumbersFromConsole();
            string[] numbersStr = number.ToString().Split('.');
            string result = "";
            temp = "";

            for (int i = 0; i < numbersStr.Length; i++)
            {
                ReverseManager.reverse(numbersStr[i], out temp);
                result += temp + ".";
            }

            result = result.Remove(result.Length - 1);
            number = double.Parse(result);
            Console.WriteLine(number);
        }

        public static void commandReverseArray(int[] array)
        {
            int[] result;
            ConsoleHandler.fillArray(array);
            ReverseManager.reverse(ref array, out result);
            showArray(result);
        }
        public static void showArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ",");
            }
        }
    }
}
