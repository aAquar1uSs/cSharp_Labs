using LabNumber9.Abstract;
using LabNumber9.Task3.Interfaces;
using LabNumber9.Task3.Utils;
using System;

namespace LabNumber9.Task1
{
    class Square : Shape
    {
        private double sideLength;
        protected override string Color { get; set; }
        protected override int AmountTop => 4;
        protected override string Name {get;}

        public Square(string name, double sizeSide, string color) 
            : base(color)
        {
            Name = name;
            sideLength = sizeSide;
        }


        public override double CalculatePerimeter()
        {
            return sideLength * 4;
        }

        public override double CalculateArea()
        {
            return Math.Pow(sideLength,2);
        }

        public override void  Draw()
        {
            ColorManager.setConcoleColor(Color);
            Console.WriteLine($"Name= {Name}" + "\n" + $"Size= {sideLength}");
            Console.ResetColor();
        }
    }
}
