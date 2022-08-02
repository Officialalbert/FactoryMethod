namespace Factorymethod
{
    internal interface IMAGAZIN
    {
        public decimal Price { get; }
        public string Description { get; set; }

        public decimal GetPrice();
    }
}
