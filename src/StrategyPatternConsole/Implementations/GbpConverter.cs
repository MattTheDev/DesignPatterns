using StrategyPatternConsole.Contract;

namespace StrategyPatternConsole.Implementations
{
    public class GbpConverter : ICurrencyConverter
    {
        public double ConversionRate => 0.74;
        public string Symbol => "GBP";

        public double ConvertCurrency(double usdAmount)
        {
            return usdAmount * ConversionRate;
        }
    }
}
