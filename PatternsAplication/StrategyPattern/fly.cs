using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class fly:IMovementMethod
    {
        public double CalculateDisplacement(List<double> coordinates, List<double> velocity, List<double> aceleration, double timeSeconds)
        {
            return 0;
        }
    }
}
