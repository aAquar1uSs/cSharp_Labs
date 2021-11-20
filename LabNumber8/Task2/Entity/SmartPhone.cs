using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber8.Task2.Entity
{
    class SmartPhone : ColourPhone
    {

        SmartPhone()
        {

        }
        public override void CreatePhoto()
        {
            Console.WriteLine("You create photo!");
        }

        public override void CreateVideo()
        {
            Console.WriteLine("You create video!");
        }
    }
}
