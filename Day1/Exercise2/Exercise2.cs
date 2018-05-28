using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
             
            // Using While Loop
            int count=0;
            int[] statuses = new int[] {1, 2, 3, 4};
            int status=0;
            while (count < statuses.Length)
           
            {
                status=statuses[count];


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

                 count++;
            }



        }
    }   
}