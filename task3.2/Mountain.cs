﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3._2
{
    public class Mountain : IGeographicalObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Peak { get; set; }

        public void Information()
        {
            Console.WriteLine($"Назва: {Name}");
            Console.WriteLine($"Опис: {Description}");
            Console.WriteLine($"Координати: ({X}, {Y})");
            Console.WriteLine($"Найвища точка: {Peak} м");
        }
    }
}
