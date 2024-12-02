using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Team
    {
        public string NameOfTeam { get; }
        private List<Worker> workers = new List<Worker>();

        public Team(string nameOfTeam)
        {
            NameOfTeam = nameOfTeam;
        }
        public bool ExistenceСheck(Worker worker)
        {
            foreach (var existingWorker in workers)
            {
                if (existingWorker.Name == worker.Name &&
                    existingWorker.Position == worker.Position &&
                    existingWorker.WorkDay == worker.WorkDay)
                {
                    return true; 
                }
            }
            return false;
        }
        public void AddWorker(Worker worker)
        {

            if (!ExistenceСheck(worker))
            {
                workers.Add(worker);
            }
            else
            {
                Console.WriteLine("This worker was already added before");
            }
        }
        public void PrintTeamInfo()
        {
            Console.WriteLine($"Team: {NameOfTeam}");
            Console.WriteLine("Employees:");
            foreach (var worker in workers)
            {
                Console.WriteLine($"{worker.Name}");
            }
        }
        public void PrintDetailedTeamInfo()
        {
            Console.WriteLine($"\nTeam: {NameOfTeam}");
            Console.WriteLine("Detailed information:");
            Console.WriteLine("{0,-20} | {1,-15} | {2,-10}", "Name", "Position", "WorkDay");
            foreach (var worker in workers)
            {
                Console.WriteLine("{0,-20} | {1,-15} | {2,-10}", worker.Name, worker.Position, worker.WorkDay);
            }
        }
    }
}
