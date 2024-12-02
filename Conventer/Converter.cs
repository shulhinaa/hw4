using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class Converter
    {
        private readonly Dictionary<string, IConversionStrategy> strategies = new();

        public void SetStrategy(string operation, IConversionStrategy strategy)
        {
            strategies[operation] = strategy;
        }

        public bool HasStrategy(string operation)
        {
            return strategies.ContainsKey(operation);
        }

        public decimal ExecuteStrategy(string operation, decimal amount)
        {
            if (strategies.ContainsKey(operation))
            {
                return strategies[operation].Convert(amount);
            }
            throw new InvalidOperationException("No strategy found for the given operation.");
        }
    }
}
