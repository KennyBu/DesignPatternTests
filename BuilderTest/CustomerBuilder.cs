namespace BuilderTest
{
    
    
    
    public class CustomerBuilder
    {
        private string _firstName { get; set; }
        private string _lastName { get; set; }

        public CustomerBuilder WithFirstName(string firstName)
        {
            _firstName = firstName;
            return this;
        }

        public CustomerBuilder WithLastName(string lastName)
        {
            _lastName = lastName;
            return this;
        }

        public ICustomer Build()
        {
            return new Customer{FirstName = _firstName, LastName = _lastName};
        }
    }

    public class CustomerWithAddressBuilder
    {
        private string _street { get; set; }
        private string _city { get; set; }
        private string _zip { get; set; }

        public CustomerWithAddressBuilder WithFirstName(string street)
        {
            _street = street;
            return this;
        }

        public CustomerWithAddressBuilder WithCity(string city)
        {
            _city = city;
            return this;
        }

        public CustomerWithAddressBuilder WithZip(string zip)
        {
            _zip = zip;
            return this;
        }

        


    }
}