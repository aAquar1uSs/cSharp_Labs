using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Task2.Entity
{
    class Rotaries
    {
        private string phoneNumber;
        private char[] validSymbols;

        protected string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        protected char[] ValidSymbols { get => validSymbols; set => validSymbols = value; }

        public Rotaries(string number)
        {
            PhoneNumber = number ;
            ValidSymbols = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' }
        }

        public void MakeTheCall() => Console.WriteLine("You make the call!");

        public void TakeTheCall() => Console.WriteLine("You take the call!");
    

        public  override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < ValidSymbols.Length; i++)
            {
                stringBuilder.Append(ValidSymbols[i]);
            }
            return "Rotaries phone: " + '\n' +
                $"Phone number: {PhoneNumber}" + '\n' +
                $"Valid symbols: {stringBuilder}" ;
        }

    }
}
