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

        public double getVoltage()
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

        public void consoleHandler()
        {
            Console.Write("Voltage =");
            setVoltage(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Amperage =");
            setAmperage(Convert.ToDouble(Console.ReadLine()));
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.consoleHandler();
            Console.WriteLine(p.calculateR());
            Console.ReadLine();
        }
    }
}
