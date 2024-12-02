using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    class Developer : Worker
    {
        public Developer(string name) : base(name) { Position = "Developer"; WorkDay = string.Empty; }
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
            WriteCode();
            Call();
            Relax();
            WriteCode();
        }
    }
}
