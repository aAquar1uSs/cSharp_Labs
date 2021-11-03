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
        public static void lab10_main()
        {
            Console.WriteLine("\nLab number 10:\n ");
            string buffer = "";


            int number = ConsoleHandler.readNumbersFromConsole();
            Console.WriteLine(number.reverse_ExtensionMethod());

            string word = ConsoleHandler.readStringsFromConsole();
            Console.WriteLine(word.reverse_ExtensionMethod());

            string[] str = ConsoleHandler.readStringsFromConsole().Split(',');
        
            for(int i = 0; i < str.Length;i++)
            {
                buffer += str[i].reverse_ExtensionMethod();
                buffer += ',';
            }
            buffer = buffer.Remove(buffer.Length - 1);
            Console.WriteLine(buffer);
            buffer = "";


            double num = ConsoleHandler.readDoubleNumbersFromConsole();
            string[] numbersStr = num.ToString().Split('.');
     
            for (int i = 0; i < numbersStr.Length; i++)
            {
                buffer += numbersStr[i].reverse_ExtensionMethod();
                buffer += ".";
            }

            buffer = buffer.Remove(buffer.Length - 1);
            num = double.Parse(buffer);
            Console.WriteLine(num);


        }
    }
}
