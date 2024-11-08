using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRM;

namespace ECommerce1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 89;
            customer1.FirstName = "Rajas";
            customer1.LastName = "Doshi";
            customer1.Email = "rp@gmail.com";
            customer1.Contact = "9038498038";

            Customer customer2 = new Customer();
            customer2.Id = 89;
            customer2.FirstName = "Ash";
            customer2.LastName = "Pandey";
            customer2.Email = "ap@gmail.com";
            customer2.Contact = "8964498038";

            ICustomerService customerService = new CustomerService();

            customerService.Insert(customer1);
            customerService.Insert(customer2);

            List<Customer> allCustomers = customerService.GetAll();

            foreach (Customer customer in allCustomers)
            {
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.Email);
                Console.WriteLine(customer.Contact);
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
