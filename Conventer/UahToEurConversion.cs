using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class UahToEurConversion : IConversionStrategy
    {
        private readonly decimal eurRate;

        public UahToEurConversion(decimal eurRate)
        {
            this.eurRate = eurRate;
        }

        public decimal Convert(decimal amount)
        {
            return amount / eurRate;
        }
    }
}
