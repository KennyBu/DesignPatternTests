using System;

namespace BuilderTest
{
    class Program
    {
        static void Main()
        {
            const string firstName = "Luke";
            const string lastName = "Skywalker";

            var customer = new CustomerBuilder()
                .WithFirstName(firstName)
                .WithLastName(lastName)
                .Build();

            Console.WriteLine("Customer: FirstName={0} LastName={1}",customer.FirstName,customer.LastName);
            Console.Read();
        }
    }
}
