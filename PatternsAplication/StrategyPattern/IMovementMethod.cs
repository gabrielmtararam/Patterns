using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StrategyPattern
{
   public  interface  IMovementMethod
    {
        double CalculateDisplacement(List<double> coordinates, List<double> velocity, List<double> aceleration, double timeSeconds);


    }
}
