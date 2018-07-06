using System;
using System.Collections.Generic;


namespace ZombieData
{
    class Program
    {
        static void Main(string[] args)
        {
            StatusRepository repository = new StatusRepository();
            List<Status> statuses = repository.GetAll();
            foreach (Status status in statuses)
            {
                Console.WriteLine(status.FirstName +" "+status.LastName + " "+
                status.StatusDescription);
            }
        }
    }
}
