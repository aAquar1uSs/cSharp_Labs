﻿using LabNumber6.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber6
{
    class Program
    {
        private const int CAPACITY = 10;
        private static string temp = "";

        static void Main(string[] args)
        {
            int[] array = new int[CAPACITY];

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
            commandReverseArray(array);

            //Lab 10
            Console.WriteLine("\nEven index: ");
            array.evenIndex(); //разширение метода
 
            Console.WriteLine("\n----------------------------------");
            Console.WriteLine("\nOdd index: ");
            array.oddIndex();          

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
            string str = ConsoleHandler.readStringsFromConsole();
            string[] words = str.Split(',');
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

        public static void commandReverseDoubleNumbers()
        {
            double number = ConsoleHandler.readDoubleNumbersFromConsole();
            string n = number.ToString();
            string[] numbersStr = n.Split('.');
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
