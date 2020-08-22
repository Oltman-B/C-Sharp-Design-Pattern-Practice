using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternPractice
{
    class Squeak : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squeak");
        }
    }
}
