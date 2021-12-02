using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Task2.Entity
{
    class Rotaries : Phone
    {
        protected int phoneNumber;
        protected string[] validSymbols;

        public Rotaries(int number)
        {
            SetPhoneNumber(number);
            SetValidSymbol(new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" });
        }

        public void SetPhoneNumber(int number)
        {
            phoneNumber = number;
        }

        public void SetValidSymbol(string[] symb)
        {
            validSymbols = symb;
        }

        public virtual void MakeTheCall()
        {
            Console.WriteLine("You make the call!");
        }

        public virtual void TakeTheCall()
        {
            Console.WriteLine("You take the call!");
        }

        public virtual void SendSMS(string message)
        {
            throw new NotSupportedException();
        }

        public virtual void TakeSMS()
        {
            throw new NotSupportedException();
        }

        public virtual void SendMMS(string message)
        {
            throw new NotSupportedException();
        }

        public virtual void TakeMMS()
        {
            throw new NotSupportedException();
        }

        public virtual void CreatePhoto()
        {
            throw new NotSupportedException();
        }

        public virtual void CreateVideo()
        {
            throw new NotSupportedException();
        }

        public  override string ToString()
        {
            string buffer = "";
            for (int i = 0; i < validSymbols.Length; i++)
            {
                buffer += validSymbols[i];
            }
            return "Rotaries phone: " + '\n' +
                $"Phone number: {phoneNumber}" + '\n' +
                $"Valid symbols: {buffer}" ;
        }

    }
}
