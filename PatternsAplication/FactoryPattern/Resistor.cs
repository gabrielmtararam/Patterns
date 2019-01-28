using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Resistor:IEletronic
    {
        public double MaxVoltage { get; set; }
        public double MaxAmps { get; set; }
        public bool explosible { get; set; }
        public double _resistance;

        public Resistor(double MaxAmps, double MaxVoltage, double resistance)
        {
            this.MaxAmps = MaxAmps;
            this.MaxVoltage = MaxVoltage;
            explosible = false;
            _resistance = resistance;
        }
        public string CustomToString()
        {
            return " this is a Resistor";
        }
    }
}
