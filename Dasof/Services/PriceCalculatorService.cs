using Dasof.Models;

namespace Dasof.Services
{
    public class PriceCalculatorService : IPriceCalculatorService
    {
        public GetPriceResponse GetPrice(GetPrice getPrice)
        {
            double basePriceNet = 0.0;
            double basePriceGross = 0.0;
            double equipmentPriceNet = 0.0;
            double equipmentPriceGross = 0.0;

            if (getPrice.IsBasePriceGross)
            {
                basePriceNet = RemoveVat(getPrice.BasePrice, getPrice.VatRate);
                basePriceGross = getPrice.BasePrice;
            }
            else
            {
                basePriceGross = getPrice.BasePrice + AddVat(getPrice.BasePrice, getPrice.VatRate);
                basePriceNet = getPrice.BasePrice;
            }

            if (getPrice.IsEquipmentPriceGross)
            {
                equipmentPriceNet = RemoveVat(getPrice.EquipmentPrice, getPrice.VatRate);
                equipmentPriceGross = getPrice.EquipmentPrice;
            }
            else
            {
                equipmentPriceGross = getPrice.EquipmentPrice + AddVat(getPrice.EquipmentPrice, getPrice.VatRate);
                equipmentPriceNet = getPrice.EquipmentPrice;
            }

            return new GetPriceResponse(
                getPrice.VatRate,
                basePriceGross,
                basePriceNet,
                getPrice.IsBasePriceGross,
                equipmentPriceGross,
                equipmentPriceNet,
                getPrice.IsEquipmentPriceGross);
        }

        private double AddVat(double price, double vatRate) => (price / 100) * vatRate;

        private double RemoveVat(double price, double vatRate) => price / (1 + (vatRate / 100));
    }
}
