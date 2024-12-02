using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Converter
{
    public class ConverterController
    {
        private readonly Converter converter;

        public ConverterController()
        {
            Console.WriteLine("Welcome to the Currency Converter!");

            decimal usdToUah = GetValidExchangeRate("Enter the USD to UAH exchange rate: ");
            decimal eurToUah = GetValidExchangeRate("Enter the EUR to UAH exchange rate: ");

            converter = new Converter();

            converter.SetStrategy("UAH_TO_USD", new UahToUsdConversion(usdToUah));
            converter.SetStrategy("UAH_TO_EUR", new UahToEurConversion(eurToUah));
            converter.SetStrategy("USD_TO_UAH", new UsdToUahConversion(usdToUah));
            converter.SetStrategy("EUR_TO_UAH", new EurToUahConversion(eurToUah));
        }

        public void Run()
        {
            while (true)
            {
                decimal amount = GetValidAmount();
                string operation = GetConversionOperation();

                ExecuteConversion(amount, operation);

                if (!AskToContinue())
                {
                    Console.WriteLine("Thank you for using the Currency Converter!");
                    break;
                }
            }
        }

        private decimal GetValidExchangeRate(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (decimal.TryParse(Console.ReadLine(), out decimal rate) && rate > 0)
                {
                    return rate;
                }
                Console.WriteLine("Invalid input. Exchange rate must be a positive number greater than zero.");
            }
        }

        private decimal GetValidAmount()
        {
            while (true)
            {
                Console.Write("Enter the amount to convert: ");
                if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0)
                {
                    return amount;
                }
                Console.WriteLine("Invalid amount. Please enter a positive number.");
            }
        }

        private string GetConversionOperation()
        {
            Console.Write("Choose operation (UAH_TO_USD, UAH_TO_EUR, USD_TO_UAH, EUR_TO_UAH): ");
            return Console.ReadLine()?.ToUpper();
        }

        private void ExecuteConversion(decimal amount, string operation)
        {
            if (converter.HasStrategy(operation))
            {
                decimal result = converter.ExecuteStrategy(operation, amount);
                Console.WriteLine($"Converted amount: {result:F2}");
            }
            else
            {
                Console.WriteLine("Invalid operation. Please choose a valid conversion.");
            }
        }

        private bool AskToContinue()
        {
            Console.Write("Do you want to perform another conversion? (yes/no): ");
            return Console.ReadLine().Equals("yes", StringComparison.OrdinalIgnoreCase);
        }
    }
}
