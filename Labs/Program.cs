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

        public double Voltage
        {
            get => voltage;
            set => voltage = value;
        }

        public double Amperage
        {
            get => amperage;
            set => amperage = value;
        }

        public Program()
        {
            Voltage = default;
            Amperage = default; 
        }

        public double CalculateR()
        {
            return Voltage / Amperage;
        }

        public void ConsoleHandler()
        {
            Console.Write("Voltage =");
            Voltage = Convert.ToDouble(Console.ReadLine());
            Console.Write("Amperage =");
            Amperage =Convert.ToDouble(Console.ReadLine());
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
