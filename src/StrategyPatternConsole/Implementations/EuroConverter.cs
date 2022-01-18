using StrategyPatternConsole.Contract;

namespace StrategyPatternConsole.Implementations
{
    public class EuroConverter : ICurrencyConverter
    {
        public double ConversionRate => 0.88;
        public string Symbol => "EURO";

        public double ConvertCurrency(double usdAmount)
        {
            return usdAmount * ConversionRate;
        }
    }
}
