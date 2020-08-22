using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternPractice
{
    internal class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying by rocket power, watch out Elon...");
        }
    }
}
