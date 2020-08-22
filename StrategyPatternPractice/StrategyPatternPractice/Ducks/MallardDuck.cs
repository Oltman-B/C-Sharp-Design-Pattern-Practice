using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternPractice
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            QuackBehavior = new Quack();
            FlyBehavior = new FlyWithWings();
        }
        public override void display()
        {
            Console.WriteLine("I'm a real live mallard duck!");
        }
    }
}
