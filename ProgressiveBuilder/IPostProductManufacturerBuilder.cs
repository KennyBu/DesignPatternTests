namespace ProgressiveBuilder
{
    public interface IPostProductManufacturerBuilder
    {
        IPostProductManufacturerBuilder Costs(double cost);
        Product Priced(double price);
    }
}