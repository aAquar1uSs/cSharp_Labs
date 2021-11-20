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

        public ColourPhone(int number) //default value
        {
            phoneNumber = number;
            numberColor = 160;
            isTwoSimCard = false;
            secondNumber = 0;
        }

        public ColourPhone(int numberColor,bool isTwoSimCard, int secondNumber)
        {
            this.numberColor = numberColor;
            this.isTwoSimCard = isTwoSimCard;
            this.secondNumber = secondNumber;
        }

        public override void SendMMS(string message)
        {
            Console.WriteLine("You sent this MMS" + message);
        }

        public override void TakeMMS()
        {
            Console.WriteLine("New MMS!!");
        }

    }
}
