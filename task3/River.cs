using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class River : GeographicalObject
    {
        public double Speed { get; set; }
        public double Length { get; set; }

        public override void Information()
        {
            base.Information();
            Console.WriteLine($"Швидкість течії: {Speed} см/с");
            Console.WriteLine($"Загальна довжина: {Length} км");
        }
    }
}
