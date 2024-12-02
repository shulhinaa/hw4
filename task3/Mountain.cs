using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class Mountain : GeographicalObject
    {
        public double Peak { get; set; }

        public override void Information()
        {
            base.Information();
            Console.WriteLine($"Найвища точка: {Peak} м");
        }
    }
}
