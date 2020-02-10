using Microsoft.AspNetCore.Mvc;
using Calculations.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;

namespace Calculations.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class BudgetController : ControllerBase
  {
    private readonly ILogger<BudgetController> _logger;
    private readonly ICalculationService _service;
    public BudgetController(ILogger<BudgetController> logger, ICalculationService service)
    {
      _logger = logger;
      _service = service;
    }

    [HttpGet("{id}")]
    public IEnumerable<string> Retrieve(string id)
    {
      _logger.LogTrace($"Retrieving Budget for '{id}'");
      return Enumerable.Range(1, 1).Select(index => _service.returnValue()).ToArray();
    }
  }
}