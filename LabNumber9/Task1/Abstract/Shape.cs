using LabNumber9.Task3.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabNumber9.Abstract
{
    abstract class Shape : IDraw
    {
        protected abstract string Color { get; set; }
        protected abstract int AmountTop { get; } // read-only property
        protected abstract string Name { get; } // read-only property

        public Shape(string color) 
        {
            Color = color;
        }
        public string GetName()
        {
            return Name;
        }

        public abstract double CalculateArea();

        public abstract double CalculatePerimeter();

        public override string ToString()
        {
            return $"Name: {Name}" + "\n" + $"Amount top: {AmountTop}" + "\n" 
                + $"Color: {Color}" + "\n" + $"Perimeter: {CalculatePerimeter()}" +
               "\n" + $"Area: {CalculateArea()}";
        }

        public abstract void Draw();
    }
}
