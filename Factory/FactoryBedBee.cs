using Factorymethod.Domain;

namespace Factorymethod.Factory
{
    internal class FactoryBedBee : FactoryFirst
    {
        public decimal _price { get; set; }
        public string _description { get; set; }
        public FactoryBedBee(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override IMAGAZIN GetMAGAZIN()
        {
            BedBee Bedbee = new(_price)
            {
                Description = _description
            };
            return Bedbee;
        }
    }
}
