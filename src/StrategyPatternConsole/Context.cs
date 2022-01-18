using StrategyPatternConsole.Contract;

namespace StrategyPatternConsole;

public class Context
{
    private ICurrencyConverter _currencyConverter;

    public Context()
    {

    }

    public Context(ICurrencyConverter currencyConverter)
    {
        _currencyConverter = currencyConverter;
    }

    public void SetConverter(ICurrencyConverter currencyConverter)
    {
        _currencyConverter = currencyConverter;
    }

    public void Convert(double usdAmount)
    {
        var result = _currencyConverter.ConvertCurrency(usdAmount);
        Console.WriteLine($"{usdAmount:N} USD is {result} {_currencyConverter.Symbol}. Current rate is 1:{_currencyConverter.ConversionRate}.");
    }
}