using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    public class TeamManager
    {
        private List<Team> teams = new List<Team>();

        public bool TeamExistenceCheck(string name)
        {
            foreach (var team in teams)
            {
                if (team.NameOfTeam == name)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsPossibleCreate(string position)
        {
            if (position != "developer" || position != "manager")  
            {
                return true;
            }
            return false;
        }

        private Worker CreateWorker(string name, string position)
        {
            if (position == "developer")
            {
                Worker developer = new Developer(name);
                return developer;
            }
            else
            {
                Worker manager = new Manager(name);
                return manager;
            }
        }

        public void Run()
        {
            Console.WriteLine("Welcome to the Team Management App!");
            Console.WriteLine("You will be able to create teams, add workers, and view team information.");

            bool addTeam = true;

            while (addTeam)
            {
                Console.Write("Enter team name: ");
                string teamName = Console.ReadLine();

                if (TeamExistenceCheck(teamName))
                {
                    Console.WriteLine("A team with this name already exists. Please choose a different name.");
                    continue;  
                }

                Team team = new Team(teamName);  
                teams.Add(team);  

                bool addWorker = true;
                while (addWorker)
                {
                    Console.Write("Do you want to add a worker? (yes/no): ");
                    string answer = Console.ReadLine();

                    if (answer == "yes")
                    {
                        Console.Write("Enter the worker's name: ");
                        string workerName = Console.ReadLine();

                        Console.Write("Enter the worker's position (developer or manager): ");
                        string position = Console.ReadLine();

                        if (!IsPossibleCreate(position))
                        {
                            Console.WriteLine("Worker could not be created due to invalid position.");
                            continue;  
                        }
                        Worker worker = CreateWorker(workerName, position);

                        team.AddWorker(worker);
                        Console.WriteLine("Worker added successfully.");
                        worker.FillWorkDay();
                    }
                    else if (answer == "no")
                    {
                        addWorker = false;  
                    }
                }


                Console.Write("Do you want to add another team? (yes/no): ");
                string addAnotherTeam = Console.ReadLine();
                if (addAnotherTeam.ToLower() != "yes")
                {
                    addTeam = false;  
                }
            }

            Console.Write("Do you want detailed team information? (yes/no): ");
            string detailedInfo = Console.ReadLine();
            if (detailedInfo == "yes")
            {
                foreach (var team in teams)
                {
                    team.PrintDetailedTeamInfo();  
                }
            }
        }
    }


}
