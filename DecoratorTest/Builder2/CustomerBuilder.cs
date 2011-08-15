namespace Builder2
{
    public class CustomerBuilder
    {
        private string _firstName;
        private string _lastName;

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

       public Customer Build()
       {
           return new Customer {FirstName = _firstName, LastName = _lastName};
       }

        public static implicit operator Customer(CustomerBuilder builder)
        {
            return builder.Build();
        } 
    }
}