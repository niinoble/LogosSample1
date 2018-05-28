using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int status=3;

            Pstatus("Carlton");
            Console.WriteLine(Getstatus(status));
        
        }
        private static string Getstatus(int status)
            {
                    
                  if (status==1)
                {
                     return ("Alive");
                 }
                else if (status==2)
                {
                     return ("Zombie");
                }
                else if (status==3)
                {
                      return ("Dead");
                }
                else
                {
            
                     return ("Unknown");
                }
            }    

         private static void Pstatus(string person)
        {
            Console.WriteLine(person +"'s status is: ");
        }   
            
        
    }
}
