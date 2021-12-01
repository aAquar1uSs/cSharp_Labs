using LabNumber8.Entity;
using LabNumber8.Task1.Utils;
using LabNumber8.Task2.Entity;
using LabNumber8.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabNumber8.Task1.Entity;

namespace LabNumber8
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage(10);
            garage.RegisterDelegate(new Garage.ErrorStateHandler(Color_Message));

            while (true)
            {
                Console.Clear();
                ConsoleHandler.FirstMessage();
                int number = ConsoleHandler.SelectAction();

                if (number == 0)
                    break;

                Console.Clear();
                ActionHandler.Actions(number, garage);
            }
            Console.ReadLine();
        }

        private static void Color_Message(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ReadLine();
            Console.ResetColor();
        }
    }
}
