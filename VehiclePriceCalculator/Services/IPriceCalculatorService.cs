using VehiclePriceCalculator.Models;

namespace VehiclePriceCalculator.Services
{
    public interface IPriceCalculatorService
    {
        GetPriceResponseViewModel GetPrice(GetPriceRequestViewModel getPrice);
    }
}
