using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public static class EletronicFactory
    {
        public  static IEletronic LoadEletronic()
        {
            var random = new Random();
            int rand = random.Next(0, 2);

            switch (rand)
            {
                case 0:
                    return new Capacitor(0,0,0);
                case 1:
                    return new Resistor(0, 0, 0);
                default:
                    return new Resistor(0, 0, 0);
            }


        }
    }
}
