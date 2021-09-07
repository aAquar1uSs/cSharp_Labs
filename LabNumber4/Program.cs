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

        public Program(int number, int sizeArr)
        {
            setNumber(number);
            setArraySize(sizeArr);
            initArray();
        }

        public int getNumber()
        {
            return number;
        }

        public void setNumber(int v)
        {
            number = v;
        }

        public void setArraySize(int size)
        {
            arr_size = size;
        }

        public int getArraySize()
        {
            return arr_size;
        }

        private void initArray()
        {
            arr = new int[getArraySize()];
            Random random = new Random();
            for(int index = 0; index < getArraySize();index++)
            {
                arr[index] = random.Next(-30,30);
            }
        }

        public void showArray()
        {
            for (int index = 0; index < getArraySize(); index++)
            {
                Console.WriteLine(arr[index]);
            }
        }

        public void arraySort()
        {
            int temp;
            for (int i = 0; i < getArraySize() - 1; i++)
            {
                for (int j = i + 1; j < getArraySize(); j++)
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

        public void calculated()
        {
            int i;
            int firstNumber = 0;
            int secondNumber = 0;
            for(i = 0; i < getArraySize();i++)
            {
                int left = i;
                int right = getArraySize() - 1;
                while(right > left)
                {
                    if(arr[right] + arr[left] - getNumber() == 0)
                    {
                        firstNumber = arr[right];
                        secondNumber = arr[left];
                    }

                    if (arr[right] + arr[left] - getNumber() > 0)
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
        
        public void readAndWriteInConsole()
        {
            Console.Write("Enter number =");
            setNumber(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Enter array size");
            setArraySize(Convert.ToInt32(Console.ReadLine()));
        }

        static void Main(string[] args)
        {
            Program p = new Program(20,20);
            p.arraySort();
            p.showArray();
            p.calculated();
            Console.ReadLine();
        }
    }
}
