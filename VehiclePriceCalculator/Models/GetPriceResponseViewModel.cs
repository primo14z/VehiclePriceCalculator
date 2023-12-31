﻿namespace VehiclePriceCalculator.Models
{
    public class GetPriceResponseViewModel
    {
        public GetPriceResponseViewModel(
            VatRate vatRate,
            decimal basePriceGross,
            decimal basePriceNet,
            bool isBasePriceGross,
            decimal equipmentPriceGross,
            decimal equipmentPriceNet,
            bool isEquipmentPriceGross
            )
        {
            VatRate = vatRate;
            if (basePriceGross < 0 || basePriceNet < 0 || equipmentPriceGross < 0 || equipmentPriceNet < 0)
            {
                throw new ArgumentException("Price calculation cannot be less than 0.");
            }
            BasePriceGross = basePriceGross;
            BasePriceNet = basePriceNet;
            IsBasePriceGross = isBasePriceGross;
            EquipmentPriceGross = equipmentPriceGross;
            EquipmentPriceNet = equipmentPriceNet;
            IsEquipmentPriceGross = isEquipmentPriceGross;
            TotalPriceGross = basePriceGross + equipmentPriceGross;
            TotalPriceNet = basePriceNet + equipmentPriceNet;
        }

        public VatRate VatRate { get; set; }
        public decimal BasePriceGross { get; set; }
        public decimal BasePriceNet { get; set; }
        public bool IsBasePriceGross { get; set; }
        public decimal EquipmentPriceGross { get; set; }
        public decimal EquipmentPriceNet { get; set; }
        public bool IsEquipmentPriceGross { get; set; }
        public decimal TotalPriceGross { get; set; }
        public decimal TotalPriceNet { get; set; }


    }
}
