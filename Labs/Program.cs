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

        public double GetVoltage()
        {
            return voltage;
        }

        public void SetVoltage(double v)
        {
            this.voltage = v;
        }

        public double GetAmperage()
        {
            return amperage;
        }

        public void SetAmperage(double a)
        {
            this.amperage = a;
        }

        public double CalculateR()
        {
            return voltage / amperage;
        }

        public void ConsoleHandler()
        {
            Console.Write("Voltage =");
            SetVoltage(Convert.ToDouble(Console.ReadLine()));
            Console.Write("Amperage =");
            SetAmperage(Convert.ToDouble(Console.ReadLine()));
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            p.ConsoleHandler();
            Console.WriteLine(p.CalculateR());
            Console.ReadLine();
        }
    }
}
