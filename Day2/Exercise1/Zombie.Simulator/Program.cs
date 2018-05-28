using System;



namespace Zombie.Simulator
{    class Program
    {
        static void Main(string[] args)
        {
                    
           
           

            Human Human1 = new Human();
            Zombie zombie = new Zombie();

            Human1.run(10);
            zombie.Walk(10);
            Console.WriteLine("Human walked  " + Human1.DistanceTraveled);
            Console.WriteLine("Zombie Walked " + zombie.DistanceTraveled);
        }
    }

    
}
