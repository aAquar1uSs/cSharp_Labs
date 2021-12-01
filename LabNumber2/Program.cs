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

        public double N { get => n; set => n = value; }
        public double K { get => k; set => k = value; }

        public Program()
        {
            //init variables
            nn = default;
            nk = default;
            result = default;

            //init methods
            ConsoleHandler();
            SearchOfUnknownVariables();
        }

        public void Calculate()
        {
            if(!IsValidate(nn, nk))
            {
                Console.WriteLine("isValidate::Error::Please set the numbers like this: 0 <= nn <= nk ");
                return ;
            }
           
            for(double i = nn; i <= nk; i++)
            {
                result += (Math.Pow(K, 2) - Math.Pow((-1), K + 1) * Math.Pow(K, 3)) /
                    Math.Pow(K, 2) + K + 1;
            }
        }

        private void SearchOfUnknownVariables()
        {
            nn = Math.Pow(N,2);
            nk = N * K;
        }

        private bool IsValidate(double i1,double i2)
        {
            if (i2 >= i1 && i1 >= 0) {
                return true;
            }

            return false;
        }

        public void ConsoleHandler()
        {
            Console.Write("N =");
            N = Convert.ToDouble(Console.ReadLine());
            Console.Write("k =");
            K = Convert.ToDouble(Console.ReadLine());

        }

        public void Print()
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
            Program p = new Program();
            p.Calculate();
            p.Print();
        }
    }
}
