namespace Factorymethod.Domain
{
    internal class BedTea : IMAGAZIN
    {
        public decimal _price { get; set; }
        public string _description { get; set; }
        public BedTea(decimal Price)
        {
            _price = Price;
            _description = Description;
        }
        public decimal Price => _price;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
