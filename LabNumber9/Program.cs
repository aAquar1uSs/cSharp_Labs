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
            Shape circle = new Circle("Circle",6);
            Console.WriteLine(circle);

            Console.WriteLine("Picture----------------------------------------------");
            Picture picture = new Picture(4);

            picture.add(triangle);
            picture.add(circle);
            picture.add(square);
            picture.add(triangle);

            //picture.delete("Square");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(picture.get(1));
            Console.WriteLine("------------------------------------------------------");
            picture.printAll();

            Painter.paint(picture);
        }
    }
}
