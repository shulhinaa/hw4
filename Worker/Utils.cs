﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    static internal class Utils
    {
        private static Random random = new Random();
        public static int GetRandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }
    }
}
