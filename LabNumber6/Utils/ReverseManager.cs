using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber6.Utils
{
    class ReverseManager
    {
        public static void reverse(int value)
        {
            Console.Write(value % 10);

            if (value > 9)
                reverse(value / 10); 
        }

        public static void reverse(string str)
        {
            if (str.Length > 0)
                reverse(str.Substring(1, str.Length - 1));
            else
                return;

            Console.Write(str[0]);
        }

        public static void reverse(double value)
        {
            double dst = 0;
            int decPoint = 0;

            while (value - (long)value > 0)
            {
                value = value * 10;
                decPoint++;
            }

            int totalDigits = 0;

            while (value > 0)
            {
                int d = (int)value % 10;
                dst = dst * 10 + d;
                value = (long)(value / 10);
                totalDigits++;
            }

            if (decPoint > 0)
            {
                int reversedDecPoint = totalDigits - decPoint;
                for (int i = 0; i < reversedDecPoint; i++) dst = dst / 10;
            }
            Console.WriteLine(dst);
        }

        public static void reverseArray(ref int[] array, out int [] result)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }
            result = array;
        }
    }
}
