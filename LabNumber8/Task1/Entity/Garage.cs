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
        private List<Car> garage;

        public Garage()
        {
            garage = new List<Car>(defaultCapacity);
            capacity = defaultCapacity;
        }

        public Garage(int capacity)
        {
            garage = new List<Car>(capacity);
            this.capacity = capacity;
        }

        public void AddCar(Car car)
        {
            if (garage.Count >= capacity)
                Console.WriteLine("Oopss,lack of space, sell a car or buy a new garage))))");
            else
                garage.Add(car);
        }

        public void SaleCar(int numberPlace)
        {
            try
            {
                garage.Remove(garage[numberPlace]);
            } catch (Exception e)
            {
                Console.WriteLine("Error:: Such a car does not exist!" + e.Message);
                Console.ReadLine();
            }
        }

        public void ShowAllCars()
        {
            for(int i = 0;i < garage.Count;i++)
            {
                Console.WriteLine("Place: " + i);
                Console.WriteLine(garage[i]);
                Console.WriteLine("------------------");
            }
        }

        public void TakeTheCar()
        {

        }
    }
}
