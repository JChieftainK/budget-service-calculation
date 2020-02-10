using Microsoft.AspNetCore.Mvc;
using Calculations.Services;
using System.Collections.Generic;
using System.Linq;
using Serilog;

namespace Calculations.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class BudgetController : ControllerBase
  {
    private readonly ILogger _logger;
    private readonly ICalculationService _service;
    
    public BudgetController(ICalculationService service)
    {
      _logger = Log.ForContext<BudgetController>();
      _service = service;
    }

    [HttpGet("{id}")]
    public IEnumerable<string> Retrieve(string id)
    {
      _logger.Debug($"Retrieving Budget for '{id}'");
      return Enumerable.Range(1, 1).Select(index => _service.returnValue()).ToArray();
    }
  }
}