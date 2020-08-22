using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternPractice
{
    class MuteQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("<< SILENCE >>...");
        }
    }
}
