using LabNumber6.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Reverse int 
            ReverseManager.reverse(ConsoleHandler.readNumbersFromConsole());

            Console.WriteLine();

            //Reverse string
            string str = ConsoleHandler.readStringsFromConsole();
            string[] words = str.Split(',');
            
            for (int i = 0; i < words.Length; i++)
            {
                ReverseManager.reverse(words[i]);
                Console.Write(",");
            }
          
            Console.WriteLine();

            //Reverse double(float)
            ReverseManager.reverse(ConsoleHandler.readDoubleNumbersFromConsole());

            //Reverse array 
            int[] array = new int[10];
            ConsoleHandler.fillArray(array);
            int[] result;
            ReverseManager.reverseArray(ref array,out result);
            
            for(int i =0;i < result.Length;i++)
            {
                Console.Write(result[i] + ",");
            }

            Console.Read();
        }
    }
}
