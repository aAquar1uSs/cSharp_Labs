using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Task2.Entity
{
    class SmartPhone : ColourPhone
    {
        public SmartPhone(int number, int numberColor, bool isTwoSimCard, int secondNumber,
            float res, double sizeScreen, string color)
            : base(number,numberColor,isTwoSimCard,secondNumber,res,sizeScreen,color)
        {
            SetValidSymbol(new string[15] { "1", "2", "3", "4", "5",
                "6", "7", "8", "9", "0", "*", "#", "!", "-", "+" });
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
