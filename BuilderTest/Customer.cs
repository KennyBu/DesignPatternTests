namespace BuilderTest
{
    public interface ICustomer
    {
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    public interface IHaveanAddress
    {
        string Street { get; set; }
        string City { get; set; }
        string Zip { get; set; }
    }

    public interface IHaveCustomerWithAddress : ICustomer, IHaveanAddress
    {
        
    }

    public class Customer : ICustomer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    
    public class CustomerWithAddress : IHaveCustomerWithAddress
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
    }
}