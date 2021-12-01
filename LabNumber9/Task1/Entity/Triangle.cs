using LabNumber9.Abstract;
using LabNumber9.Task3.Interfaces;
using LabNumber9.Task3.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabNumber9.Task1.Entity
{
    class Triangle : Shape
    {
        private double sizeSide;

        protected override string Color { get; set; }

        protected override int AmountTop => 3;

        protected override string Name { get; }

        public Triangle(string name)
        {
            Name = name;
            Color = "Yellow";
            sizeSide = 10;
        }

        public Triangle(string name, double size)
        {
            Name = name;
            sizeSide = size;
            Color = "Yellow";
        }

        public Triangle(string name, double size, string color)
            :base(color)
        {
            Name = name;
            sizeSide = size;
        }

        public override double calculatePerimeter()
        {
            return sizeSide * 3;
        }

        public override double calculateArea()
        {
            return (Math.Sqrt(3) / 4) * (Math.Pow(sizeSide, 2));
        }

        public override void Draw()
        {
            ColorManager.setConcoleColor(Color);
            Console.WriteLine($"Name= {Name}" + "\n" + $"Size= {sizeSide}");
            Console.ResetColor();
        }
    }
}
