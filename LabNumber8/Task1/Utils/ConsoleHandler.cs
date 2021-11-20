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
                "1 - To buy a new car;" + '\n' + 
                "2 - Sell the car;" + '\n' +
                "3 - Check garage;" + '\n' +
                "4 - Take the car by full parametrs;" + '\n' +
                "5 - Take the car by:" + '\n' +
                "6 - Park the car;" + '\n' +
                "7 - Show empty places;" + '\n' +
                "0 - Exit;");
        }
        
        public static void MessageAboutCarParametrs()
        {
            Console.WriteLine("Please choose parametr!" + '\n' +
                "1 - By name" + '\n' +
                "2 - By model" + '\n' +
                "3 - By year" + '\n' +
                "4 - By cost" + '\n' +
                "5 - By color" + '\n');        }

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

        public static string SelectCarName()
        {
            Console.WriteLine("Please enter name:");
            return Console.ReadLine();
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
