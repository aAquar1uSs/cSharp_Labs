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

        public int X1 { get => x1; set => x1 = value; }
        public int X2 { get => x2; set => x2 = value; }
        public int Y1 { get => y1; set => y1 = value; }
        public int Y2 { get => y2; set => y2 = value; }

        public Program()
        {
            X1 = default;
            X2 = default;
            Y1 = default;
            Y2 = default;
        }

        public bool Calculate()
        {
            //получаем модуль числа
            if (Math.Abs(X1 - X2) <= 1 && Math.Abs(Y1 - Y2) <= 1)
            {
                return true;
            }

            return false;
        }

        public void ConsoleHandler()
        {
            Console.WriteLine("Set the coordinates for the first board.");
            Console.Write("X1 =");
            X1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y1 =");
            Y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Set the coordinates for the second board.");
            Console.Write("X2 =");
            X2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Y2 =");
            Y2 = Convert.ToInt32(Console.ReadLine());
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
