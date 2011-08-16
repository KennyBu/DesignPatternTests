namespace ProgressiveBuilder
{
    public interface IPreProductNameBuilder
    {
        IPostProductNameBuilder Named(string name);
    }
}