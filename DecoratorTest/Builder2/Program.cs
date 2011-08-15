using System;

namespace Builder2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string firstName = "Darth";
            const string lastName = "Vader";

            Customer customer = new CustomerBuilder()
                .WithFirstName(firstName)
                .WithLastName(lastName);

            Console.WriteLine("Customer: FirstName={0} LastName={1}", customer.FirstName, customer.LastName);
            Console.Read();
        }
    }
}
