 using System;
 
 namespace Zombie.Simulator
 {
 public abstract class Person
    
    {
        public int DistanceTraveled{get; set;}

        public virtual void Walk(int minutes)
        {
            DistanceTraveled = DistanceTraveled+ (1* minutes);

        }

        public Person()
        {
            
            Console.WriteLine("A new person has been created");
        }
        

    }

 }