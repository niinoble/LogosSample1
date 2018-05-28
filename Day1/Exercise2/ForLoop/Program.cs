using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
            
                do
                {
                Console.Write(statuses[count] + " ");

                //switch statement
                switch (statuses[count])
                {
                    case 1:
                        Console.WriteLine(" Alive");
                        break;
                    case 2:
                        Console.WriteLine(" Zombie");
                        break;
                    case 3:
                        Console.WriteLine (" Dead");
                        break;
                    case 4:
                        Console.WriteLine(" Unknown");
                        break;
                }
                count++;
            } while(count < statuses.Length);

            for(count = 0; count < statuses.Length; count++)
            {
                Console.Write(names[counter] + " ");
                //switch statement
                switch (statuses[counter])
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

            counter = 0;
            foreach(int status in statuses)
            {
                Console.Write(names[counter] + " ");
                //switch statement
                switch (status)
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
                counter++;
            }
        }
    }
}









































        }
    }
}
