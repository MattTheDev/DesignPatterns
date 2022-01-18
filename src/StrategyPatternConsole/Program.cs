using StrategyPatternConsole;
using StrategyPatternConsole.Implementations;

var context = new Context();

context.SetConverter(new EuroConverter());
context.Convert(5.37);

context.SetConverter(new GbpConverter());
context.Convert(9.42);