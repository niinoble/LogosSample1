using System;
namespace Zombie.Simulator
{
    public sealed class Human : Person
    {
      
        public void run(int minutes)
        {
            DistanceTraveled += minutes * 20;
        }
       
    }
}