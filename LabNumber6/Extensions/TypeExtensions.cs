using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber6.Extensions
{
    public static class TypeExtensions
    {
        public static int Reverse_ExtensionMethod(this int value)
        {
            int result = 0;
            while (value > 0)
            {
                result = result * 10 + value % 10;
                value /= 10;
            }

            return result;
        } 

        public static string Reverse_ExtensionMethod(this string str)
        {
            string reversedString = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedString += str[i];
            }

            return reversedString;
        }

        public static void Reverse_ExtensionMethod(this double num)
        {
            int iPart = (int)num;
            
            double dPart = 0;

            ConvertDecimalPartToInt(ref dPart, num, iPart);

            // reverse the integer part
            Console.Write(iPart.Reverse_ExtensionMethod());
            Console.Write(".");

            // reverse the decimal part
            Console.Write(((int)dPart).Reverse_ExtensionMethod());
        }

        public static int[] Reverse_ExtensionMethod(this int[] array)   
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }

            return array;
        }

        private static int GetDecimalDigitsCount(double number)
        {
            string[] str = number.ToString(new System.Globalization.NumberFormatInfo() { NumberDecimalSeparator = "." }).Split('.');
            return str.Length == 2 ? str[1].Length : 0;
        }

        private static void ConvertDecimalPartToInt(ref double dPart, double num ,double iPart)
        {
            int count = GetDecimalDigitsCount(num);

            switch (count)
            {
                case 1:
                    dPart = (num - iPart) * 10;
                    break;
                case 2:
                    dPart = (num - iPart) * 100;
                    break;
                case 3:
                    dPart = (num - iPart) * 1000;
                    break;
                default:
                    Console.WriteLine("Error.");
                    break;
            }
        }
    }
}
