using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber3
{
    class Program
    {
        private int x1;
        private int x2;
        private int y1;
        private int y2;


        public Program()
        {
            x1 = 0;
            x2 = 0;
            y1 = 0;
            y2 = 0;
        }

        public int GetX1()
        {
            return x1;
        }

        public void SetX1(int value)
        {
            x1 = value;
        }

        public int GetX2()
        {
            return x2;
        }

        public void SetX2(int value)
        {
            x2 = value;
        }

        public int GetY1()
        {
            return y1;
        }

        public void SetY1(int value)
        {
            y1 = value;
        }

        public int GetY2()
        {
            return y2;
        }

        public void SetY2(int value)
        {
            this.y2 = value;
        }

        public bool Calculate()
        {
            //получаем модуль числа
            if (Math.Abs(GetX1() - GetX2()) <= 1 && Math.Abs(GetY1() - GetY2()) <= 1)
            {
                return true;
            }

            return false;
        }

        public void ConsoleHandler()
        {
            Console.WriteLine("Set the coordinates for the first board.");
            Console.Write("X1 =");
            SetX1(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Y1 =");
            SetY1(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Set the coordinates for the second board.");
            Console.Write("X2 =");
            SetX2(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Y2 =");
            SetY2(Convert.ToInt32(Console.ReadLine()));
        }


        static void Main(string[] args)
        {
            Program p = new Program();
            p.ConsoleHandler();

            Console.WriteLine(p.Calculate());
            Console.ReadLine();
        }
    }
}
