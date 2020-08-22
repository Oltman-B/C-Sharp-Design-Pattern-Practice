using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternPractice
{
    class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Way to rub it in...");
        }
    }
}
