﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public interface IConversionStrategy
    {
        decimal Convert(decimal amount);
    }
}
