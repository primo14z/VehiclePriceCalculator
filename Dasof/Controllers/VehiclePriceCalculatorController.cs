using Dasof.Models;
using Dasof.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dasof.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehiclePriceCalculatorController : ControllerBase
    {
        private readonly ILogger<VehiclePriceCalculatorController> _logger;
        private readonly IPriceCalculatorService _priceCalculatorService;

        public VehiclePriceCalculatorController(ILogger<VehiclePriceCalculatorController> logger, IPriceCalculatorService priceCalculatorService)
        {
            _logger = logger;
            _priceCalculatorService = priceCalculatorService;
        }

        [HttpPost]
        public GetPriceResponse GetPrice(GetPrice getPrice)
        {
            return _priceCalculatorService.GetPrice(getPrice);
        }
    }
}