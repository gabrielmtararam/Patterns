using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
     class Capacitor:IEletronic
    {
       public double MaxVoltage { get; set; }
       public double MaxAmps { get; set; }
       public bool explosible { get; set; }
       public double _capacitance;
     
        public Capacitor(double MaxAmps, double MaxVoltage, double capacitance)
        {
            this.MaxAmps = MaxAmps;
            this.MaxVoltage = MaxVoltage;
            explosible = true;
            _capacitance = capacitance;
        }

        public string CustomToString()
        {
            return " this is a capacitor";
        }
       
    }
}
