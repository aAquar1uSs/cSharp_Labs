using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Task2.Entity
{ 
    class TouchTonePhone : Rotaries
    {
        public TouchTonePhone()
        {
            SetPhoneNumber(0);
            SetValidSymbol(new string[12] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "*", "#" });
        }

        public TouchTonePhone(int number)
        {
            SetPhoneNumber(number);
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
            string buffer = "";
            for(int i = 0; i < validSymbols.Length; i++)
            {
                buffer += validSymbols[i];
            }

            return "Touch Tone Phone: " + '\n' +
                "Number: " + phoneNumber + '\n' + 
                "Valid symbols: " + buffer;
        }


    }
}
