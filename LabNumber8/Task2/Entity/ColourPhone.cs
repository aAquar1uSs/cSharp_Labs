using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Task2.Entity
{
    class ColourPhone : BlackWhiteScreenPhone
    {
        private int numberColor;
        private bool isTwoSimCard1;
        private int secondNumber;

        protected int NumberColor { get => numberColor; set => numberColor = value; }
        protected bool IsTwoSimCard1 { get => isTwoSimCard1; set => isTwoSimCard1 = value; }
        protected int SecondNumber { get => secondNumber; set => secondNumber = value; }

        public ColourPhone(string number,int numberColor,bool isTwoSimCard, int secondNumber,
            float res, double sizeScreen, string color)
            : base(number,res,sizeScreen,color)
        {
            NumberColor = numberColor;
            IsTwoSimCard1 = isTwoSimCard;
            SetSecondNumber(secondNumber);
            ValidSymbols = new char[15] { '1', '2', '3', '4', '5',
                '6', '7', '8', '9', '0', '*', '#', '!', '-', '+' };
        }
        public void SetSecondNumber(int secondNumber)
        {
            if (IsTwoSimCard1)
            {
                SecondNumber = secondNumber;
            }
        }

        public void SendMMS(string message) => Console.WriteLine("You sent this MMS: " + message);

        public void TakeMMS() => Console.WriteLine("New MMS!!");

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < ValidSymbols.Length; i++)
            {
                stringBuilder.Append(ValidSymbols[i]);
            }

            return "Colour Phone: " + '\n' +
                $"Resolution: {Resolution}" + '\n' +
                $"Number phone: {PhoneNumber}" + '\n' +
                $"Second number: {SecondNumber}" + '\n' +
                $"Color: {Color}" + '\n' +
                $"Size screen: {SizeScreen}" + '\n' +
                $"Valid symbols: {stringBuilder}";

        }

    }
}
