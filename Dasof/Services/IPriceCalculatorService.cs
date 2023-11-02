using Dasof.Models;

namespace Dasof.Services
{
    public interface IPriceCalculatorService
    {
        public GetPriceResponse GetPrice(GetPrice getPrice);
    }
}
