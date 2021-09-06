using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Program
    {
        private double voltage; //напряжение
        private double amperage; // Сила тока


        public Program()
        {
            voltage = 0;
            amperage = 0;
        }

        public Program(double v, double a)
        {
            this.voltage = v;
            this.amperage = a;
        }

        public double getVolage()
        {
            return voltage;
        }

        public void setVoltage(double v)
        {
            this.voltage = v;
        }

        public double getAmperage()
        {
            return amperage;
        }

        public void setAmperage(double a)
        {
            this.amperage = a;
        }

        public double calculateR()
        {
            return voltage / amperage;
        }



        static void Main(string[] args)
        {
            Program p = new Program();
            p.setVoltage(36);
            p.setAmperage(0.024);
            Console.WriteLine("Init constructor without parametrs");
            Console.WriteLine(p.calculateR());

            Program p2 = new Program(40, 0.008);
            Console.WriteLine("Using constructor with parametrs");
            Console.WriteLine(p2.calculateR());

            Console.ReadLine();
        }
    }
}
