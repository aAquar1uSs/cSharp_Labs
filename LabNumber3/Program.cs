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

        public int getX1()
        {
            return x1;
        }

        public void setX1(int value)
        {
            this.x1 = value;
        }

        public int getX2()
        {
            return x2;
        }

        public void setX2(int value)
        {
            this.x2 = value;
        }

        public int getY1()
        {
            return y1;
        }

        public void setY1(int value)
        {
            this.y1 = value;
        }

        public int getY2()
        {
            return y2;
        }

        public void setY2(int value)
        {
            this.y2 = value;
        }

        public bool calculate()
        {
            //получаем модуль числа
            if (Math.Abs(getX1() - getX2()) <= 1 && Math.Abs(getY1() - getY2()) <= 1)
            {
                return true;
            }

            return false;
        }

        public void writeAndReadConsole()
        {
            Console.WriteLine("Set the coordinates for the first board.");
            Console.Write("X1 =");
            setX1(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Y1 =");
            setY1(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Set the coordinates for the second board.");
            Console.Write("X2 =");
            setX2(Convert.ToInt32(Console.ReadLine()));
            Console.Write("Y2 =");
            setY2(Convert.ToInt32(Console.ReadLine()));
        }


        static void Main(string[] args)
        {
         
            Program p = new Program();
            p.writeAndReadConsole();

            Console.WriteLine(p.calculate());
            Console.ReadLine();
        }
    }
}
