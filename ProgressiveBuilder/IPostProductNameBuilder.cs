namespace ProgressiveBuilder
{
    public interface IPostProductNameBuilder
    {
        IPostProductManufacturerBuilder ManufacturedBy(string manufacturer);
    }
}