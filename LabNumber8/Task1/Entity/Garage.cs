using System;
using LabNumber8.Entity;
using LabNumber8.Utils;

namespace LabNumber8.Task1.Entity
{
    class Garage
    {
        private static int defaultCapacity = 3;
        private readonly int capacity;
        private readonly Car[] garage;
        private Car currentCar;

        public delegate void ErrorStateHandler(string message);

        ErrorStateHandler error;

        public Garage()
        {
            garage = new Car[defaultCapacity];
            capacity = defaultCapacity;
            currentCar = null;
            InitGaragePlaces();
        }

        public Garage(int capacity)
        {
            garage = new Car[capacity];
            this.capacity = capacity;
            currentCar = null;
            InitGaragePlaces();
        }

        public void RegisterDelegate(ErrorStateHandler err)
        {
            error = err;
        }

        public void UnregisterDeligate(ErrorStateHandler err)
        {
            error -= err;
        }
        private void InitGaragePlaces()
        {
            for (int i = 0; i < garage.Length; i++)
            {
                garage[i] = null;
            }
        }

        public void AddCar(Car car)
        {
            if(garage.Length > capacity)
            {
                error("Error::Lack of garage space!");
                return;
            }
            ShowEmptyPlaces();
            Add(car, ConsoleHandler.SelectEmptyPlace());

        }

        public void SaleCar(int numberPlace)
        {
           if(numberPlace > capacity && garage[numberPlace] == null)
            {
                error("Error::Please choose correct place!");
                return;
            }
            garage[numberPlace] = null;
        }

        public void ShowAllCars()
        {
            for (int i = 0; i < garage.Length; i++)
            {
                if (garage[i] != null)
                {
                    Console.WriteLine($"Place: {i}");
                    Console.WriteLine(garage[i]);
                    Console.WriteLine("------------------------");
                }
            }
        }

        public void TakeTheCar(int place)
        {
            if(place > capacity)
            {
                error("Error::Please choose correct place!");
                return;
            }

            currentCar = garage[place];
            garage[place] = null;
        }

        public void ParkTheCar(int place)
        {
            if (place > capacity)
            {
                error("Error::Please choose correct place!");
                return;
            }

            garage[place] = currentCar;
            currentCar = null;
        }

        public void ShowEmptyPlaces()
        {
            for(int i =0; i < garage.Length;i++)
            {
                if(garage[i] == null)
                {
                    Console.WriteLine($"Place: {i} empty!");
                }
            }
        }

        public void FindCarsByParametrs(string parametr, int index) 
        {
            switch(index)
            {
                case 1:
                    FindByName(parametr);
                    break;
                case 2:
                    FindByModel(parametr);
                    break;
                case 3:
                    FindByYear(Convert.ToInt32(parametr));
                    break;
                case 4:
                    FindByColor(parametr);
                    break;
                default:
                    Console.WriteLine("Error::Wrong operation!");
                    Console.ReadLine();
                    break;
            }
        }


        private void FindByName(string name)
        {
           for(int i = 0; i < garage.Length;i++)
           {
                if(garage[i] != null && garage[i].Name == name)
                {
                    Console.WriteLine($"Place: {i}");
                    Console.WriteLine(garage[i]);
                }
           }
        }

        private void FindByModel(string model)
        {
            for (int i = 0; i < garage.Length; i++)
            {
                if (garage[i] != null && garage[i].Model == model)
                {
                    Console.WriteLine($"Place: {i}");
                    Console.WriteLine(garage[i]);
                }
            }
        }

        private void FindByYear(int year)
        {
            for (int i = 0; i < garage.Length; i++)
            {
                if (garage[i] != null && garage[i].Year == year)
                {
                    Console.WriteLine($"Place: {i}");
                    Console.WriteLine(garage[i]);
                }
            }
        }

        private void FindByColor(string color)
        {
            for (int i = 0; i < garage.Length; i++)
            {
                if (garage[i] != null && garage[i].Color == color)
                {
                    Console.WriteLine($"Place: {i}");
                    Console.WriteLine(garage[i]);
                }
            }
        }

        private void Add(Car car, int index) 
        {
            if(garage.Length <= index || garage[index] != null)
            {
                error("Error::Please choose correct place!");
                return;
            }

            garage[index] = car;
        }

    }
}
