using System;
using System.Collections.Generic;
using System.Text;

namespace LabNumber9.Abstract
{
    abstract class Shape
    {
        protected abstract string Color { get; set; }
        protected abstract int AmountTop { get; } // read-only property
        protected abstract string Name { get; } // read-only property

        public Shape(string color) 
        {
            Color = color;
        }

        public Shape()
        {
            Color = "None";
        }

        public abstract double calculateArea();

        public abstract double calculatePerimeter();

        public override string ToString()
        {
            return "Name: " + Name + "\n" + "Amount top: " + AmountTop + "\n" 
                + "Color: " + Color + "\n" + "Perimeter: " + calculatePerimeter() +
               "\n" + "Square: " + calculateArea();
        }

    }
}
