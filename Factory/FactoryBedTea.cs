using Factorymethod.Domain;

namespace Factorymethod.Factory
{
    internal class FactoryBedTea : FactoryFirst
    {
        public decimal _price { get; set; }
        public string _description { get; set; }
        public FactoryBedTea(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMAGAZIN GetMAGAZIN()
        {
            BedTea Bedtea = new(_price)
            {
                Description = _description
            };
            return Bedtea;
        }
    }
}
