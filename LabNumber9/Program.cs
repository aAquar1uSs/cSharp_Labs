using LabNumber9.Abstract;
using LabNumber9.Task1;
using LabNumber9.Task1.Entity;
using LabNumber9.Task2.Collection;
using LabNumber9.Task3.Utils;
using System;

namespace LabNumber9
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Square-----------------------------------------------");
            Shape square  = new Square("Square",7,"Red");
            Console.WriteLine(square);

            Console.WriteLine("Triangle----------------------------------------------");
            Shape triangle = new Triangle("Triangle", 10, "Yellow");
            Console.WriteLine(triangle);

            Console.WriteLine("Circle----------------------------------------------");
            Shape circle = new Circle("Circle",6,"Blue");
            Console.WriteLine(circle);

            Console.WriteLine("Picture----------------------------------------------");
            Picture picture = new Picture(4);

            picture.Add(triangle);
            picture.Add(circle);
            picture.Add(square);
            picture.Add(triangle);

            //picture.delete("Square");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(picture.Get(1));
            Console.WriteLine("------------------------------------------------------");
            picture.PrintAll();

            Painter.paint(picture);
        }
    }
}
