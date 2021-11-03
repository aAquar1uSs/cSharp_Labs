﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber6.Extensions
{
    public static class TypeExtensions
    {
        public static int reverse_ExtensionMethod(this int value)
        {
            int result = 0;
            while (value > 0)
            {
                result = result * 10 + value % 10;
                value /= 10;
            }

            return result;
        } 

        public static string reverse_ExtensionMethod(this string str)
        {
            string reversedString = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedString += str[i];
            }

            return reversedString;
        }
    }
}
