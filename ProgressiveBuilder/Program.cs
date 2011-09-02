using System;

namespace ProgressiveBuilder
{
    class Program
    {
        static void Main()
        {
            //Test for Growl Notification
            Product product = ProductBuilder
                .CreateProduct()
                .Named("Darth Vader")
                .ManufacturedBy("Kenner")
                .Costs(.99)
                .Priced(4.99);

            Console.WriteLine("Product - Name: {0} Price: {1} Manufacturer: {2}",product.Name,product.Price,product.Manufacturer);
            Console.Read();
        }
    }
}
