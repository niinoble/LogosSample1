using System;
namespace Zombie.Simulator
{
    public sealed class Zombie : Person
    {
        public override void Walk(int minutes)
        {
            DistanceTraveled -= minutes * 5;
        }
    }
}