﻿using System.Text;

namespace task3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            IGeographicalObject river = new River
            {
                X = 10.5,
                Y = 20.3,
                Name = "Дніпро",
                Description = "Найбільша річка в Україні",
                Speed = 120,
                Length = 2201
            };

            IGeographicalObject mountain = new Mountain
            {
                X = 50.1,
                Y = 30.4,
                Name = "Говерла",
                Description = "Найвища гора в Україні",
                Peak = 2061
            };

            river.Information();
            Console.WriteLine();
            mountain.Information();
        }
    }

}
