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
            try{
                return Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine("Please, input correct data.-------->" + e);
            }
            return 0;
        }

        public static string readStringsFromConsole()
        {
            Console.WriteLine("Enter strings:");
            try{
                return Console.ReadLine();
            } catch(Exception e)
            {
                Console.WriteLine("Please, input correct data.-------->" + e);
            }
            return "";
        }

        public static double readDoubleNumbersFromConsole()
        {
            Console.WriteLine("Enter values with point:");
            try { 
                return Convert.ToDouble(Console.ReadLine());
            } catch(Exception e)
            {
                Console.WriteLine("Please, input correct data.-------->" + e);
            }
            return 0;
        }

        public static void fillArray(int[] array)
        {
            Console.WriteLine("Please fill array: ");
            for(int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
 