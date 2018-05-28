using System;

namespace Exercise2_WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing count variable and Array.
            int count=0;
            int[] statuses = new int[] {1, 2, 3, 4};
       

            // Using the while loop
            while(count < statuses.Length)
            {

                
                //switch statement
                switch (statuses[count])
                {
                    case 1:
                        Console.WriteLine("Alive");
                        break;
                    case 2:
                        Console.WriteLine("Zombie");
                        break;
                    case 3:
                        Console.WriteLine ("Dead");
                        break;
                    case 4:
                        Console.WriteLine("Unknown");
                        break;
                }
               count++;
            }
        }
    }
}
