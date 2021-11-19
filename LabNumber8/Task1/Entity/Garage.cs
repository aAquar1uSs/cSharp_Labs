using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Entity
{
    class Garage
    {
        private static int defaultCapacity = 3;
        private int capacity;
        private Car[] garage;
        private Car currentCar;

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

        public void AddCar(Car car)
        {
            if(garage.Length > capacity)
            {
                Console.WriteLine("Error::Lack of garage space!");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Please choose empty place!");
            ShowEmptyPlaces();
            Add(car, Convert.ToInt32(Console.ReadLine()));

        }

        public void SaleCar(int numberPlace)
        {
           if(numberPlace > capacity && garage[numberPlace] == null)
            {
                Console.WriteLine("Error::Please choose correct place!");
                Console.ReadLine();
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
                    Console.WriteLine("Place:" + i);
                    Console.WriteLine(garage[i]);
                    Console.WriteLine("------------------------");
                }
            }
        }

        public void TakeTheCar(int place)
        {
            if(place > capacity)
            {
                Console.WriteLine("Error::Please choose correct place!");
                Console.ReadLine();
                return;
            }

            currentCar = garage[place];
            garage[place] = null;
        }

        public void ParkTheCar(int place)
        {
            if (place > capacity)
            {
                Console.WriteLine("Error::Please choose correct place!");
                Console.ReadLine();
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
                    Console.WriteLine("Place: " + i + " empty!");
                }
            }
        }

        private void Add(Car car, int index) 
        {
            if(garage.Length <= index && garage[index] != null)
            {
                Console.WriteLine("Error::Please choose correct place");
                return;
            }

            garage[index] = car;
        }

        private void InitGaragePlaces()
        {
            for(int i = 0; i < garage.Length;i++)
            {
                garage[i] = null;
            }
        }
    }
}
