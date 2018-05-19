using System;

namespace testProject
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int employeeStatus=1;
            
            switch(employeeStatus)
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
                default:
                    Console.WriteLine("Unknown");
                    break;
            }        
        }
    }
}
