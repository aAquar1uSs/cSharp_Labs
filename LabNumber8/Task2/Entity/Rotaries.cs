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
        protected List<string> validSymbols;

        public Rotaries()
        {
            phoneNumber = 0;
        }
        public Rotaries(int number)
        {
            phoneNumber = number;

            validSymbols = new List<string>();
            validSymbols.Add("1");
            validSymbols.Add("2");
            validSymbols.Add("3");
            validSymbols.Add("4");
            validSymbols.Add("5");
            validSymbols.Add("6");
            validSymbols.Add("7");
            validSymbols.Add("8");
            validSymbols.Add("9");
            validSymbols.Add("0");
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
            throw new NotImplementedException();
        }

        public virtual void TakeSMS()
        {
            throw new NotImplementedException();
        }

        public virtual void SendMMS(string message)
        {
            throw new NotImplementedException();
        }

        public virtual void TakeMMS()
        {
            throw new NotImplementedException();
        }

        public virtual void CreatePhoto()
        {
            throw new NotImplementedException();
        }

        public virtual void CreateVideo()
        {
            throw new NotImplementedException();
        }

        public  override string ToString()
        {
            return "Rotaries phone: " + '\n' +
                "Phone number: " + phoneNumber + '\n';
        }

    }
}
