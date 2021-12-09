using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Task2.Entity
{
    class BlackWhiteScreenPhone : TouchTonePhone
    {
        private float resolution;
        private double sizeScreen;
        private string color;

        protected float Resolution { get => resolution; set => resolution = value; }
        protected double SizeScreen { get => sizeScreen; set => sizeScreen = value; }
        protected string Color { get => color; set => color = value; }

        public BlackWhiteScreenPhone(string number ,float res,double sizeScreen,string color)
            : base(number)
        {
            Resolution = res;
            SizeScreen = sizeScreen;
            Color = color;
            ValidSymbols = new char[15] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '*', '#', '!', '-', '+' };
        }


        public void SendSMS(string message) => Console.WriteLine("You sent this SMS: " + message);

        public void TakeSMS() => Console.WriteLine("Take SMS");


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < ValidSymbols.Length; i++)
            {
                stringBuilder.Append(ValidSymbols[i]);
            }

            return "Black-White Screen Phone: " + '\n' +
                $"Resolution: {Resolution}" + '\n' +
                $"Number phone: {PhoneNumber}" + '\n' +
                $"Color: {Color}" + '\n' +
                $"Size screen: {SizeScreen}" + '\n' +
                $"Valid symbols: {stringBuilder}";

        }


    }
}
