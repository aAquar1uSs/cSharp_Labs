using LabNumber8.Entity;
using LabNumber8.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage(10);
            while (true)
            {
                Console.Clear();
                ConsoleHandler.FirstMessage();
                int number = ConsoleHandler.ChooseAction();

                if (number == 0)
                    break;

                Console.Clear();
                Actions(number, garage);
            }
            Console.ReadLine();
        }

        public static void Actions(int number, Garage garage)
        {   
            switch(number)
            {
                case 1:
                    garage.AddCar(ConsoleHandler.BuildCar());
                    break;
                case 2:
                    garage.ShowAllCars();
                    garage.SaleCar(ConsoleHandler.ChooseParkingPlace());
                    break;
                case 3:
                    garage.ShowAllCars();
                    Console.ReadLine();
                    break;
                case 4:
                    garage.ShowAllCars();
                    garage.TakeTheCar(ConsoleHandler.ChooseCar());
                    break;
                case 5:
                    garage.ShowEmptyPlaces();
                    garage.ParkTheCar(ConsoleHandler.ChooseParkingPlace());
                    break;
                case 6:
                    garage.ShowEmptyPlaces();
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Error::Wrong operation!");
                    Console.ReadLine();
                    break;
            }
        }
    }
}
