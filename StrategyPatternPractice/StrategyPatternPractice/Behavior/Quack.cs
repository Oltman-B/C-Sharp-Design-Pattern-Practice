using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternPractice
{
    internal class Quack : IQuackBehavior
    {
        void IQuackBehavior.Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
