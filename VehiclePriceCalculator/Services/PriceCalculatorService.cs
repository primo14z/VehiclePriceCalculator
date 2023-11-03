using VehiclePriceCalculator.Models;

namespace VehiclePriceCalculator.Services
{
    public class PriceCalculatorService : IPriceCalculatorService
    {
        public GetPriceResponseViewModel GetPrice(GetPriceRequestViewModel getPrice)
        {
            decimal basePriceNet;
            decimal basePriceGross;
            decimal equipmentPriceNet;
            decimal equipmentPriceGross;
            decimal vatValue = (decimal)getPrice.VatRate / 100;

            //Checking what type of Base price is selected
            if (getPrice.IsBasePriceGross)
            {
                basePriceNet = RemoveVat(getPrice.BasePrice, vatValue);
                basePriceGross = getPrice.BasePrice;
            }
            else
            {
                basePriceGross = AddVat(getPrice.BasePrice, vatValue);
                basePriceNet = getPrice.BasePrice;
            }

            //Checking what type of Equipment price is selected
            if (getPrice.IsEquipmentPriceGross)
            {
                equipmentPriceNet = RemoveVat(getPrice.EquipmentPrice, vatValue);
                equipmentPriceGross = getPrice.EquipmentPrice;
            }
            else
            {
                equipmentPriceGross = AddVat(getPrice.EquipmentPrice, vatValue);
                equipmentPriceNet = getPrice.EquipmentPrice;
            }

            return new GetPriceResponseViewModel(
                getPrice.VatRate,
                basePriceGross,
                basePriceNet,
                getPrice.IsBasePriceGross,
                equipmentPriceGross,
                equipmentPriceNet,
                getPrice.IsEquipmentPriceGross);
        }

        private decimal AddVat(decimal price, decimal vatRate) => price + (price * vatRate);

        private decimal RemoveVat(decimal price, decimal vatRate) => price / (1 + vatRate);
    }
}
