using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Task2.Entity
{
    class SmartPhone : ColourPhone
    {
        public SmartPhone(string number, int numberColor, bool isTwoSimCard, int secondNumber,
            float res, double sizeScreen, string color)
            : base(number,numberColor,isTwoSimCard,secondNumber,res,sizeScreen,color)
        {
            ValidSymbols = new char[15] { '1', '2', '3', '4', '5',
                '6', '7', '8', '9', '0', '*', '#', '!', '-', '+' };
        }

        public  void CreatePhoto() => Console.WriteLine("You create photo!");


        public void CreateVideo() => Console.WriteLine("You create video!");


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(); 
            for (int i = 0; i < ValidSymbols.Length; i++)
            {
                sb.Append(ValidSymbols[i]);
            }

            return "Colour Phone: " + '\n' +
                $"Resolution: {Resolution}" + '\n' +
                $"Number phone: {PhoneNumber}" + '\n' +
                $"Second number: {SecondNumber}" + '\n' +
                $"Color: {Color}" + '\n' +
                $"Size screen: {SizeScreen}" + '\n' +
                $"Valid symbols: {sb}";
        }
    }
}
