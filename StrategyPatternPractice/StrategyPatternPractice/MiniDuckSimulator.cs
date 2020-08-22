using System;

namespace StrategyPatternPractice
{
    class MiniDuckSimulator
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();

            Duck model = new ModelDuck();
            model.performQuack();
            model.performFly();

            model.setFlyBehavior(new FlyRocketPowered());
            model.performFly();

            model.setQuackBehavior(new Squeak());
            model.performQuack();

            model.swim();
        }
    }
}
