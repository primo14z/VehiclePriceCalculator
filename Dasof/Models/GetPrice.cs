namespace Dasof.Models
{
    public class GetPrice
    {
        public double VatRate { get; set; }
        public double BasePrice { get; set; }
        public bool IsBasePriceGross { get; set; }
        public double EquipmentPrice { get; set; }
        public bool IsEquipmentPriceGross { get; set; }
    }
}
