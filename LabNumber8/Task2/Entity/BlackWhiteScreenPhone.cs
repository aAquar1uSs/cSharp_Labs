using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Task2.Entity
{
    class BlackWhiteScreenPhone : TouchTonePhone
    {
        protected float resolution;
        protected double sizeScreen;
        protected string color;

        public BlackWhiteScreenPhone(int number ,float res,double sizeScreen,string color)
            : base(number)
        {
            SetResolution(res);
            SetSizeScreen(sizeScreen);
            SetColor(color);
            SetValidSymbol(new string[15] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "*", "#", "!", "-", "+" });
        }

        public void SetResolution(float resolution)
        {
            this.resolution = resolution;
        }

        public void SetSizeScreen(double size)
        {
            sizeScreen = size;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public override void SendSMS(string message)
        {
            Console.WriteLine("You sent this SMS: " + message);
        }

        public override void TakeSMS()
        {
            Console.WriteLine("Take SMS");
        }

        public override string ToString()
        {
            string buffer = "";
            for (int i = 0; i < validSymbols.Length; i++)
            {
                buffer += validSymbols[i];
            }

            return "Black-White Screen Phone: " + '\n' +
                $"Resolution: {resolution}" + '\n' +
                $"Number phone: {phoneNumber}" + '\n' +
                $"Color: {color}" + '\n' +
                $"Size screen: {sizeScreen}" + '\n' +
                $"Valid symbols: {buffer}";

        }


    }
}
