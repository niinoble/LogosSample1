using System;
namespace Zombie.Simulator
{
    public interface IPerson
    {
        decimal DistanceTraveled { get; set; }

        void Walk(decimal minutes);
    }
}