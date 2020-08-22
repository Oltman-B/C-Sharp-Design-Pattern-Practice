using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternPractice
{
    public abstract class Duck
    {
        internal IFlyBehavior FlyBehavior;
        internal IQuackBehavior QuackBehavior;

        public void setFlyBehavior(IFlyBehavior fb)
        {
            FlyBehavior = fb;
        }

        public void setQuackBehavior(IQuackBehavior qb)
        {
            QuackBehavior = qb;
        }

        public abstract void display();

        public void performFly()
        {
            FlyBehavior.Fly();
        }

        public void performQuack()
        {
            QuackBehavior.Quack();
        }

        public void swim()
        {
            Console.WriteLine("All ducks float, even fake ones!");
        }


    }
}
