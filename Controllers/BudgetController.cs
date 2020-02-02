using Microsoft.AspNetCore.Mvc;
using Calculations.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculations.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class BudgetController : ControllerBase
  {
    CalculationService service = new CalculationService();
    public BudgetController()
    {

    }

    [HttpGet]
    public IEnumerable<string> Get()
    {
      System.Console.WriteLine("In Budget");
      System.Console.WriteLine(Environment.GetEnvironmentVariable("TEST"));
      return Enumerable.Range(1, 1).Select(index => service.something).ToArray();
    }
  }
}