using System;

namespace Exercise2_Forloop
{
    class Program
    {
        static void Main(string[] args)
        {
            int count=0;
            int[] statuses = new int[] {1, 2, 3, 4};
           
            
            for(count = 0; count < statuses.Length; count++)
            {
               
                //Using the switch statement
                switch (statuses[count])
                {
                    case 1:
                        Console.WriteLine("Status: Alive");
                        break;
                    case 2:
                        Console.WriteLine("Status: Zombie");
                        break;
                    case 3:
                        Console.WriteLine ("Status: Dead");
                        break;
                    case 4:
                        Console.WriteLine("Status: Unknown");
                        break;
                }
            }

            
        }
    }
}




































