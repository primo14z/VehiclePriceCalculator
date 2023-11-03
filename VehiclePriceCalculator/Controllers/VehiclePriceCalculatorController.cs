using VehiclePriceCalculator.Models;
using VehiclePriceCalculator.Services;
using Microsoft.AspNetCore.Mvc;

namespace VehiclePriceCalculator.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehiclePriceCalculatorController : ControllerBase
    {
        private readonly IPriceCalculatorService _priceCalculatorService;

        public VehiclePriceCalculatorController(IPriceCalculatorService priceCalculatorService)
        {
            _priceCalculatorService = priceCalculatorService;
        }

        [HttpPost]
        public GetPriceResponseViewModel GetPrice(GetPriceRequestViewModel getPrice)
        {
            return _priceCalculatorService.GetPrice(getPrice);
        }
    }
}