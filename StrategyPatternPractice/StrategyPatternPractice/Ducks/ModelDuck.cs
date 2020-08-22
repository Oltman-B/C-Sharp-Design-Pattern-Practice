using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternPractice
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            FlyBehavior = new FlyNoWay();
            QuackBehavior = new MuteQuack();
        }
        public override void display()
        {
            Console.WriteLine("I'm just floating, can't fly though, or even quack...");
        }
    }
}
