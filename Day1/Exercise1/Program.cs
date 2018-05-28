using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
              int status = 0;
             
                  if (status==1)
                {
                     Console.WriteLine("Alive");
                 }
                else if (status==2)
                {
                     Console.WriteLine("Zombie");
                }
                else if (status==3)
                {
                     Console.WriteLine("Dead");
                }
                else
                {
            
                    Console.WriteLine("Unknown");
                }
             
             //Using the Switch statement
             int estatus=1;

             switch (estatus)
             {
                 case 1: 
                 Console.WriteLine("Alive");
                 break;

                 case 2: 
                 Console.WriteLine("Zombie");
                 break;

                 case 3: 
                 Console.WriteLine("Dead");
                 break;

                 case 4: 
                 Console.WriteLine("Unknown");
                 break;

             }
        }


    }
}
