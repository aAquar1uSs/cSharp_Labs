﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Entity
{
    class Car
    {
        private string name;
        private string model;
        private string color;
        private int year;
        private double price;
        private bool isUsing;

        public string Name { get => name; set => name = value; }
        public string Model { get => model; set => model = value; }
        public string Color { get => color; set => color = value; }
        public int Year { get => year; set => year = value; }
        public double Price { get => price; set => price = value; }
        public bool IsUsing { get => isUsing; set => isUsing = value; }

        public override string ToString()
        {
            return $"Name: {Name}" + '\n' +
                $"Model: {Model}" + '\n' +
                $"Color: {Color}" + '\n' +
                $"Year: {Year}" + '\n' +
                $"Price: {Price}";
        }
    }
}
