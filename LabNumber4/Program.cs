using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber4
{
    class Program
    {
        private int number;
        private int arr_size;
        private int[] arr;

        public Program()
        {
            ConsoleHandler();
            SetArraySize(arr_size);
            InitArray();
        }

        public int GetNumber()
        {
            return number;
        }

        public void SetNumber(int v)
        {
            number = v;
        }

        public void SetArraySize(int size)
        {
            arr_size = size;
        }

        public int GetArraySize()
        {
            return arr_size;
        }

        private void InitArray()
        {
            arr = new int[GetArraySize()];
            Random random = new Random();
            for(int index = 0; index < GetArraySize();index++)
            {
                arr[index] = random.Next(-30,30);
            }
        }

        public void ShowArray()
        {
            for (int index = 0; index < GetArraySize(); index++)
            {
                Console.WriteLine(arr[index]);
            }
        }

        public void ArraySort()
        {
            int temp;
            for (int i = 0; i < GetArraySize() - 1; i++)
            {
                for (int j = i + 1; j < GetArraySize(); j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }

        public void Calculate()
        {
            int i;
            int firstNumber = 0;
            int secondNumber = 0;
            for(i = 0; i < GetArraySize();i++)
            {
                int left = i;
                int right = GetArraySize() - 1;
                while(right > left)
                {
                    if(arr[right] + arr[left] - GetNumber() == 0)
                    {
                        firstNumber = arr[right];
                        secondNumber = arr[left];
                    }

                    if (arr[right] + arr[left] - GetNumber() > 0)
                    {
                        right--;
                    }
                    else
                        left++;
                }

            }

            Console.WriteLine("Result: ");
            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);
        }
        
        public void ConsoleHandler()
        {
            Console.Write("Enter number = ");
            SetNumber(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter array size = ");
            SetArraySize(Convert.ToInt32(Console.ReadLine()));
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.ArraySort();
            p.ShowArray();
            p.Calculate();
            Console.ReadLine();
        }
    }
}
