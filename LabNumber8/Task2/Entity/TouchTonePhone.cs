using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Task2.Entity
{ 
    class TouchTonePhone : Rotaries
    {
        public TouchTonePhone(string number) 
            : base(number)
        {
            ValidSymbols = new char[12] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '*', '#' };
        }
        
        public new void TakeTheCall() => Console.WriteLine(PhoneNumber + "This caller calls you!");


        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for(int i = 0; i < ValidSymbols.Length; i++)
            {
                stringBuilder.Append(ValidSymbols[i]);
            }

            return "Touch Tone Phone: " + '\n' +
                $"Number: {PhoneNumber}" + '\n' + 
                $"Valid symbols: {stringBuilder}";
        }


    }
}
