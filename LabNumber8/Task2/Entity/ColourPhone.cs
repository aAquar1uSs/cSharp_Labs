using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Task2.Entity
{
    class ColourPhone : BlackWhiteScreenPhone
    {
        protected int numberColor;
        protected bool isTwoSimCard;
        protected int secondNumber;

        public ColourPhone(int number,int numberColor,bool isTwoSimCard, int secondNumber,
            float res, double sizeScreen, string color)
            : base(number,res,sizeScreen,color)
        {
            SetNumberColors(numberColor);
            IsTwoSimCard(isTwoSimCard);
            SetSecondNumber(secondNumber);
            SetValidSymbol(new string[15] { "1", "2", "3", "4", "5",
                "6", "7", "8", "9", "0", "*", "#", "!", "-", "+" });
        }

        public void SetNumberColors(int numb)
        {
            numberColor = numb;
        }

        public void IsTwoSimCard(bool b)
        {
            isTwoSimCard = b;
        }

        public void SetSecondNumber(int secondNumber)
        {
            if (isTwoSimCard)
            {
                this.secondNumber = secondNumber;
            }
            else
                Console.WriteLine("Error:: You have only one SIM Card");
        }

        public override void SendMMS(string message)
        {
            Console.WriteLine("You sent this MMS: " + message);
        }

        public override void TakeMMS()
        {
            Console.WriteLine("New MMS!!");
        }

        public override string ToString()
        {
            string buffer = "";
            for (int i = 0; i < validSymbols.Length; i++)
            {
                buffer += validSymbols[i];
            }

            return "Colour Phone: " + '\n' +
                $"Resolution: {resolution}" + '\n' +
                $"Number phone: {phoneNumber}" + '\n' +
                $"Second number: {secondNumber}" + '\n' +
                $"Color: {color}" + '\n' +
                $"Size screen: {sizeScreen}" + '\n' +
                $"Valid symbols: {buffer}";

        }

    }
}
