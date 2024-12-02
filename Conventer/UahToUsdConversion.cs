using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{

    public class UahToUsdConversion : IConversionStrategy
    {
        private readonly decimal usdRate;

        public UahToUsdConversion(decimal usdRate)
        {
            this.usdRate = usdRate;
        }

        public decimal Convert(decimal amount)
        {
            return amount / usdRate;
        }
    }
}
