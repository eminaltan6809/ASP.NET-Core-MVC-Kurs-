using System.Collections.Generic;

namespace UdemyKurs.Models
{
    public static class CustomerContext
    {
        public static List<Customer> Customers = new()
        {
            new Customer {Id = 1, FirstName = "Emin", LastName= "ALTAN", Age = 25},
            new Customer {Id = 2, FirstName = "Ali",  LastName= "YILMAZ", Age = 30},
        };
    }
}
