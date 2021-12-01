using LabNumber9.Abstract;
using LabNumber9.Task3.Interfaces;
using LabNumber9.Task3.Utils;
using System;

namespace LabNumber9.Task1.Entity
{
    class Circle : Shape
    {
        private double radius;

        protected override string Color { get; set; }

        protected override int AmountTop => 0; // read-only properties

        protected override string Name { get; } // read-only properties

        public Circle(string name)
        {
            Name = name;
            Color = "Blue";
        }

        public Circle(string name,double r)
        {
            Name = name;
            radius = r;
            Color = "Blue";
        }

        public Circle(string name, double r, string color)
            : base(color)
        {
            Name = name;
            radius = r;
        }

        public override double calculateArea()
        {
            return (Math.PI * Math.Pow(radius, 2));
        }

        public override double calculatePerimeter()
        {
            return (2 * Math.PI * radius); 
        }

        public override void Draw()
        {
            ColorManager.setConcoleColor(Color);
            Console.WriteLine($"Name= {Name}" + "\n" + $"Size= {radius}");
            Console.ResetColor();
        }
    }
}
