using System;
using System.Collections.Generic;
using System.Text;

namespace ConnectWithDB
{

    class ExchangeRate
    {
        public string SourceCurrency { get; set; }
        public string DestinationCurrency { get; set; }
        public decimal Rate { get; set; }
        public bool Error { get; set; }
    }

    class Validation
    {
        public IList<ExchangeRate> ValidateExchangeRate(IList<ExchangeRate> exchangeRates,IList<string> acceptedCurrencies)
        {
            IList<ExchangeRate> InvalidExchangeRates = new List<ExchangeRate>();

            foreach (var item in exchangeRates)
            {
                if(string.IsNullOrEmpty(item.SourceCurrency) && string.IsNullOrEmpty(item.DestinationCurrency))
                {
                    InvalidExchangeRates.Add(item);
                }
                else if(item.Rate<0)
                {
                    InvalidExchangeRates.Add(item);
                }
                else if (!(acceptedCurrencies.Contains(item.SourceCurrency) && acceptedCurrencies.Contains(item.DestinationCurrency)))
                {
                    InvalidExchangeRates.Add(item);
                }
                else if (item.DestinationCurrency==item.SourceCurrency)
                {
                    if (item.Rate != 1)
                    {
                        InvalidExchangeRates.Add(item);
                    }
                }
            }

            return InvalidExchangeRates;
        }
    }
    class Class4
    {

        public static void Main4()
        {
            var acceptedCurrencies = new List<string> { 
            "INR",
            "EUR",
            "USD",
            "AED",
            "AUD"
            };

            var exchangeRates = new List<ExchangeRate>
            {
                new ExchangeRate{SourceCurrency="",DestinationCurrency=""},
                new ExchangeRate{SourceCurrency="AED"},
                 new ExchangeRate{SourceCurrency="AED"}
            };

            var validation = new Validation();
            var errorList=validation.ValidateExchangeRate(exchangeRates,acceptedCurrencies);
            foreach (var item in errorList)
            {
                Console.WriteLine(item.SourceCurrency);
                Console.WriteLine(item.DestinationCurrency);
            }
        }
    }
}
