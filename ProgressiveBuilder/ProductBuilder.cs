namespace ProgressiveBuilder
{
    public class ProductBuilder : IPreProductNameBuilder, IPostProductNameBuilder, IPostProductManufacturerBuilder
    {
        private string _manufacturer { get; set; }
        private string _name { get; set; }
        private double _cost { get; set; }
        private double _price { get; set; }

        public static IPreProductNameBuilder CreateProduct()
        {
            return new ProductBuilder();
        }

        public IPostProductNameBuilder Named(string name)
        {
            _name = name;
            return this;
        }

        public IPostProductManufacturerBuilder ManufacturedBy(string manufacturer)
        {
            _manufacturer = manufacturer;
            return this;
        }

        public IPostProductManufacturerBuilder Costs(double cost)
        {
            _cost = cost;
            return this;
        }

        public Product Priced(double price)
        {
            _price = price;
            return this;
        }

        public static implicit operator Product(ProductBuilder builder)
        {
            return builder.Build();
        }

        private Product Build()
        {
            return new Product {Name = _name, Manufacturer = _manufacturer, Cost = _cost, Price = _price};
        }
    }
}