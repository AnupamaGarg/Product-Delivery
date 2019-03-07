using System;

namespace Classes
{
    public class Customer
    {
        // Public Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Boolean IsLocal { get; set; }

        public string FullName
        {
            get
            {
                return string.Format($"{FirstName} {LastName}");
            }
        }
    }

    public class DeliveryService
    {
        /*
          Properties
        */
       
       
        public string Name { get; set; }
         public string TransitType { get; set; }

        /*
          Methods
        */
        public void Deliver(Product product, Customer customer)
        {
            Console.WriteLine($"Product delivered by {this.TransitType} to {customer.FullName}");
        }
    }

    public class Product
    {
        /*
          Properties
        */
        public string Title { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        /*
          Methods
        */
        public void Ship(Customer customer, DeliveryService service)
        {
            if (!customer.IsLocal)
            {
                service.Deliver(this, customer);
            }
        }
    }
}