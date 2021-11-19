using LabNumber8.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Utils
{
    class ConsoleHandler
    {
        public static void FirstMessage()
        {
            Console.WriteLine("Please choose action!" + '\n' +
                "1 - to buy a new car;" + '\n' + 
                "2 - sell the car" + '\n' +
                "3 - check garage;" + '\n' +
                "4 - take the car" + '\n' +
                "5 - park the car" + '\n' +
                "6 - show empty places" + '\n' +
                "0 - exit");
        }
        
        public static int SelectAction()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int SelectParkingPlace()
        {
            Console.WriteLine("Please choose the number parking place!");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int SelectCar()
        {
            Console.WriteLine("Please, choose the car!");
            return Convert.ToInt32(Console.ReadLine());
        }

        public static int SelectEmptyPlace()
        {
            Console.WriteLine("Please choose empty place!");
            return Convert.ToInt32(Console.ReadLine());
        }


        public static Car BuildCar()
        {
            Console.WriteLine("Enter the name:");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the model:");
            string model = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the color:");
            string color = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the year of manufacture:");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the price:");
            double price = Convert.ToDouble(Console.ReadLine());

            Car newCar = new Car()
            {
                Name = name,
                Model = model,
                Color = color,
                Price = price,
                Year = year,
                IsUsing = false
            };

            return newCar;
        }
    }
}
