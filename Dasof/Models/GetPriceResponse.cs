namespace Dasof.Models
{
    public class GetPriceResponse
    {
        public GetPriceResponse(
            double vatRate,
            double basePriceGross,
            double basePriceNet,
            bool isBasePriceGross,
            double equipmentPriceGross,
            double equipmentPriceNet,
            bool isEquipmentPriceGross
            )
        {
            VatRate = vatRate;
            BasePriceGross = basePriceGross;
            BasePriceNet = basePriceNet;
            IsBasePriceGross = isBasePriceGross;
            EquipmentPriceGross = equipmentPriceGross;
            EquipmentPriceNet = equipmentPriceNet;
            IsEquipmentPriceGross = isEquipmentPriceGross;
            TotalPriceGross = basePriceGross + equipmentPriceGross;
            TotalPriceNet = basePriceNet + equipmentPriceNet;
        }

        public double VatRate { get; set; }
        public double BasePriceGross { get; set; }
        public double BasePriceNet { get; set; }
        public bool IsBasePriceGross { get; set; }
        public double EquipmentPriceGross { get; set; }
        public double EquipmentPriceNet { get; set; }
        public bool IsEquipmentPriceGross { get; set; }
        public double TotalPriceGross { get; set; }
        public double TotalPriceNet { get; set; }


    }
}
