using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Task2.Entity
{
    class BlackWhiteScreenPhone : TouchTonePhone
    {
        protected double resolution;
        protected int sizeScreen;
        protected string color;
        protected List<string> validSymdolsForBWScreenPhone;

        public BlackWhiteScreenPhone(int number)//default values
        {
            phoneNumber = number;
            resolution = 1080 * 980;
            color = "Black";
            validSymdolsForBWScreenPhone = validSymbolsForTouchTonePhone;
            InitValidSymbols();
        }

        public BlackWhiteScreenPhone(double res,int sizeScreen,string color)
        {
            resolution = res;
            this.sizeScreen = sizeScreen;
            this.color = color;
            validSymdolsForBWScreenPhone = validSymbolsForTouchTonePhone;
            InitValidSymbols();
        }

        private void InitValidSymbols()
        {
            validSymdolsForBWScreenPhone.Add("+");
            validSymdolsForBWScreenPhone.Add("-");
            validSymdolsForBWScreenPhone.Add("%");
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
            return "Black-White Screen Phone: " + '\n' +
                "Resolution: " + resolution + '\n' +
                "Number phone: " + phoneNumber + '\n' +
                "Color: " + color + '\n' +
                "Size screen: " + sizeScreen + '\n';

        }


    }
}
