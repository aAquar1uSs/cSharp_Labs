using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber2
{
    class Program
    {
        private double nn;
        private double nk;
        private double n;
        private double k;
        private double result;

        public Program(double i1,double i2)
        {
            //init variables
            nn = i1;
            nk = i2;
            result = 0;

            //init methods
            searchForUnknownVariables();
        }

        public void calculate()
        {
            if(!isValidate(nn, nk))
            {
                Console.WriteLine("isValidate::Error::Please set the numbers like this: 0 <= nn <= nk ");
                return ;
            }
           
            for(double i = nn; i <= nk; i++)
            {
                result += (Math.Pow(k, 2) - Math.Pow((-1), k + 1) * Math.Pow(k, 3)) /
                    Math.Pow(k, 2) + k + 1;
            }
        }

        private void searchForUnknownVariables()
        {
            n = Math.Sqrt(nn);
            k = nk / n;
        }

        private bool isValidate(double i1,double i2)
        {
            if (i2 >= i1 && i1 >= 0) {
                return true;
            }

            return false;
        }

        public void print()
        {
            if(result == 0)
            {
                Console.WriteLine("Error");
                Console.ReadLine();
            } else
            {
                Console.WriteLine("Result: " + result);
                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            Program p = new Program(9, 12);
            p.calculate();
            p.print();
        }
    }
}
