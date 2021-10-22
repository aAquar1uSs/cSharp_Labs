using LabNumber9.Abstract;
using LabNumber9.Task1;
using LabNumber9.Task1.Entity;
using System;

namespace LabNumber9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Square-----------------------------------------------");
            Shape square  = new Square("Square",7,"RED");
            Console.WriteLine(square);

            Console.WriteLine("Triangle----------------------------------------------");
            Shape triangle = new Triangle("Triangle", 10, "Black");
            Console.WriteLine(triangle);

            Console.WriteLine("Circle----------------------------------------------");
            Shape circle = new Circle("Circle",6);
            Console.WriteLine(circle);
        }
    }
}
