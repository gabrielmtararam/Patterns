using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Animal
    {
        IMovementMethod _movementMethod;
    
        public Animal(IMovementMethod movementMethod)
        {
            _movementMethod = movementMethod;
        }
        public void  move()
        {
            _movementMethod.CalculateDisplacement(new List<double>(0), new List<double>(0), new List<double>(0), 0);
        }
    }
}
