namespace Calculations.Services 
{
  public interface ICalculationService
  {
      public string returnValue();
  }

  public class CalculationService : ICalculationService
  {
    private string something = "it works";

    public string returnValue()
    {
      return something;
    }
  }
}