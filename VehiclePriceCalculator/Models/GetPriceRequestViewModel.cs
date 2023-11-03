using System.ComponentModel.DataAnnotations;

namespace VehiclePriceCalculator.Models
{
    public class GetPriceRequestViewModel
    {
        [Required]
        public VatRate VatRate { get; set; }
        private decimal basePrice { get; set; }
        public decimal BasePrice
        {
            get
            {
                {
                    return this.basePrice;
                }
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The BasePrice should be positive!");
                }
                else
                {
                    this.basePrice = value;
                }
            }
        }
        [Required]
        public bool IsBasePriceGross { get; set; }
        private decimal equipmentPrice { get; set; }
        public decimal EquipmentPrice
        {
            get
            {
                {
                    return this.equipmentPrice;
                }
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The EquipmentPrice should be positive!");
                }
                else
                {
                    this.equipmentPrice = value;
                }
            }
        }
        [Required]
        public bool IsEquipmentPriceGross { get; set; }
    }
}
