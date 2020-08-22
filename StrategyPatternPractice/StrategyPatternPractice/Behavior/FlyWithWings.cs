using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternPractice
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying with wings!");
        }
    }
}
