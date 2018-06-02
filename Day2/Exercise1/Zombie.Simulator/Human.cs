using System;
namespace Zombie.Simulator
{
    public sealed class Human : IPerson
    {
        public decimal DistanceTraveled { get; set; }

        public void Run(decimal minutes)
        {
            DistanceTraveled += minutes * 1.5M;
        }

        public void Walk(decimal minutes)
        {
            DistanceTraveled += minutes * 1M;
        }
    }
}