using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Manager : Worker
    {
        public Manager(string name) : base(name) 
        { 
            Position = "Manager"; 
        }
        public override void WriteCode()
        {
            Console.WriteLine($"{Position} {Name} is writing code");
            WorkDay += "Write code -> ";
        }
        public override void Call()
        {
            Console.WriteLine($"{Position} {Name} is making a call");
            WorkDay += "Call -> ";
        }
        public override void Relax()
        {
            Console.WriteLine($"{Position} {Name} is having a rest");
            WorkDay += "Relax -> ";
        }

        public override void FillWorkDay()
        {
            int firstTime = Utils.GetRandomNumber(1, 11);
            for (int i = 0; i < firstTime; i++)
            {
                Call();
            }
            Relax();
            int secondTime = Utils.GetRandomNumber(1, 6);
            for (int i = 0; i < secondTime; i++)
            {
                Call();
            }
        }
    }
}

