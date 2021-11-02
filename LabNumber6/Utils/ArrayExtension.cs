using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber6.Utils
{
    public static class ArrayExtension
    {
        public static int[] evenIndex(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
            return array;
        }

        public static int[] oddIndex(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
            return array;
        }
    }
}
