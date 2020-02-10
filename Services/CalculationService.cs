using Serilog;

namespace Calculations.Services 
{
  public interface ICalculationService
  {
      public string returnValue();
  }

  public class CalculationService : ICalculationService
  {
    private readonly ILogger _log;
    private string something = "it works";

    public CalculationService()
    {
      _log = Log.ForContext<ICalculationService>();
    }

    public string returnValue()
    {
      _log.Information("Inside this");
      return something;
    }
  }
}