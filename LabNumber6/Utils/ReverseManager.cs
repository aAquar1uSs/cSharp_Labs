﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber6.Utils
{
    class ReverseManager
    {
        public static void Reverse(int value)
        {
            Console.Write(value % 10);

            if (value > 9)
                Reverse(value / 10); 
        }

        public static void Reverse(string str,out string temp)
        {
            if (str.Length > 0)
                Reverse(str.Substring(1, str.Length - 1), out temp);
            else
            {
                temp = null;
                return;
            }

            temp += str[0];
        }

        public static void Reverse(ref int[] array, out int[] result)
        {
            for (int i = 0; i < array.Length / 2; i++)
            {
                (array[i], array[array.Length - i - 1]) = (array[array.Length - i - 1], array[i]);
            }

            result = array;
        }
    }


}

