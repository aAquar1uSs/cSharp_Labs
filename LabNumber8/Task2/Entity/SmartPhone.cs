using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Task2.Entity
{
    class SmartPhone : ColourPhone
    {
        public SmartPhone()
        {
            SetPhoneNumber(0);
            SetNumberColors(0);
            SetSecondNumber(0);
            SetResolution(0);
            SetColor("");
            SetSizeScreen(0);
            SetValidSymbol(new string[15] { "1", "2", "3", "4", "5",
                "6", "7", "8", "9", "0", "*", "#", "!", "-", "+" });
        }

        public SmartPhone(int number, int numberColor, bool isTwoSimCard, int secondNumber,
            float res, double sizeScreen, string color)
        {
            SetPhoneNumber(number);
            SetNumberColors(numberColor);
            IsTwoSimCard(isTwoSimCard);
            SetSecondNumber(secondNumber);
            SetResolution(res);
            SetColor(color);
            SetSizeScreen(sizeScreen);
        }

        public override void CreatePhoto()
        {
            Console.WriteLine("You create photo!");
        }

        public override void CreateVideo()
        {
            Console.WriteLine("You create video!");
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
