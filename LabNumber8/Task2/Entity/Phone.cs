using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Task2.Entity
{
    interface Phone
    {
        void MakeTheCall();

        void TakeTheCall();

        void SendSMS(string message);

        void TakeSMS();

        void SendMMS(string message);

        void TakeMMS();

        void CreatePhoto();

        void CreateVideo();
    }
}
