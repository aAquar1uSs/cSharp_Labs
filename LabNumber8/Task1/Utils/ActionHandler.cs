using LabNumber8.Entity;
using LabNumber8.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabNumber8.Task1.Entity;

namespace LabNumber8.Task1.Utils
{
    class ActionHandler
    {
        public static void Actions(int number, Garage garage)
        {
            switch (number)
            {
                case 1:
                    garage.AddCar(ConsoleHandler.BuildCar());
                    break;
                case 2:
                    garage.ShowAllCars();
                    garage.SaleCar(ConsoleHandler.SelectParkingPlace());
                    break;
                case 3:
                    garage.ShowAllCars();
                    Console.ReadLine();
                    break;
                case 4:
                    garage.ShowAllCars();
                    garage.TakeTheCar(ConsoleHandler.SelectCar());
                    break;
                case 5:
                    SelectParametrs(garage);
                    break;
                case 6:
                    garage.ShowEmptyPlaces();
                    garage.ParkTheCar(ConsoleHandler.SelectParkingPlace());
                    break;
                case 7:
                    garage.ShowEmptyPlaces();
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Error::Wrong operation!");
                    Console.ReadLine();
                    break;
            }
        }

        private static void SelectParametrs(Garage garage)
        {
            ConsoleHandler.MessageAboutCarParametrs();
            int number = ConsoleHandler.SelectAction();

            garage.FindCarsByParametrs(ConsoleHandler.SelectCarName(), number);
            garage.TakeTheCar(ConsoleHandler.SelectCar());
        }
    }
}
