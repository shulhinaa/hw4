using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    abstract class Worker
    {
        public string Name { get; }
        public string Position { get; set; }
        public string WorkDay { get; set; }
        public Worker(string name)
        {
            Name = name;
        }
        abstract public void Call();
        abstract public void WriteCode();
        abstract public void Relax();
        abstract public void FillWorkDay();
    }
}
