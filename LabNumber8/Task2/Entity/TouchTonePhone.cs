using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Task2.Entity
{ 
    class TouchTonePhone : Rotaries
    {
        protected List<string> validSymbolsForTouchTonePhone;

        public TouchTonePhone(int number)
        {
            phoneNumber = number;
            validSymbolsForTouchTonePhone = validSymbols;
            InitValidSymbols();
        }

        private void InitValidSymbols()
        {
            validSymbolsForTouchTonePhone.Add("*");
            validSymbolsForTouchTonePhone.Add("#");
        }

        public override void MakeTheCall()
        {
            base.MakeTheCall();
        }

        public override void TakeTheCall()
        {
            Console.WriteLine(phoneNumber + "This caller calls you!");

        }

        public override string ToString()
        {
            return "Touch Tone Phone: " + '\n' +
                "Number: " + phoneNumber + '\n';
        }


    }
}
