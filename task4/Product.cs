using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public class Product : Item
    {
        public int ShelfLife { get; set; } 
        public double Quantity { get; set; } 
        public string UnitOfMeasurement { get; set; } 
    }
}
