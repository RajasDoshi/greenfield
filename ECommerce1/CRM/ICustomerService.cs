using CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public interface ICustomerService
    {
        // prototype, contract, specifications

        List<Customer> GetAll();            // abstract method 
        Customer Get(int id);

        bool Insert(Customer customer);

        bool Update(Customer customer);

        bool Delete(int id);

    }
}
