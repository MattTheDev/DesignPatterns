namespace StrategyPatternConsole.Contract
{
    public interface ICurrencyConverter
    {
        double ConversionRate { get; }
        string Symbol { get; }
        double ConvertCurrency(double usdAmount);
    }
}
