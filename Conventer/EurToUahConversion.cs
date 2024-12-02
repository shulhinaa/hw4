using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class EurToUahConversion : IConversionStrategy
    {
        private readonly decimal eurRate;

        public EurToUahConversion(decimal eurRate)
        {
            this.eurRate = eurRate;
        }

        public decimal Convert(decimal amount)
        {
            return amount * eurRate;
        }
    }
}
