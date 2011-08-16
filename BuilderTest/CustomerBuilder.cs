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

        public Customer Build()
        {
            return new Customer{FirstName = _firstName, LastName = _lastName};
        }
    }

 }