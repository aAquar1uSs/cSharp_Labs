using LabNumber9.Abstract;
using System;

namespace LabNumber9.Task1
{
    class Square : Shape
    {
        private double sideLength;
        protected override string Color { get; set; }
        protected override int AmountTop => 4;
        protected override string Name {get;}

        public Square(string name)
        {
           Name = name;
           Color = "Green";
           sideLength = 6;
        }

        public Square(string name, double sizeSide)
        {
            Name = name;
            Color = "Yellow";
            sideLength = sizeSide;
        }

        public Square(string name, double sizeSide, string color) 
            : base(color)
        {
            Name = name;
            sideLength = sizeSide;
        }


        public override double calculatePerimeter()
        {
            return sideLength * 4;
        }

        public override double calculateArea()
        {
            return Math.Pow(sideLength,2);
        }
    }
}
