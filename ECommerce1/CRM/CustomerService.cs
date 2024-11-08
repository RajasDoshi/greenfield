﻿using CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class CustomerService : ICustomerService
    {
        private List<Customer> _customerList;

        public CustomerService()
        {
            this._customerList = new List<Customer>();

        }
        public bool Delete(int id)
        {
            Customer theCustomer = Get(id);
            return this._customerList.Remove(theCustomer);
        }

        public Customer Get(int id)
        {
            foreach (Customer customer in _customerList)
            {
                if (customer.Id == id) return customer;
            }
            return null;
        }

        public List<Customer> GetAll()
        {
            return _customerList;
        }

        public bool Insert(Customer customer)
        {
            this._customerList.Add(customer);

            return true;
        }

        public bool Update(Customer customer)
        {
            // approach 1 - remove and add again
            Customer toRemove = Get(customer.Id);
            this._customerList.Remove(toRemove);

            this._customerList.Add(customer);
            return true;

            // approach 2 - find and update 
            //Customer toUpdate = Get(customer.Id);
            //toUpdate.FirstName = customer.FirstName;
            //toUpdate.LastName = customer.LastName;
            //toUpdate.Email = customer.Email;
            //return true;

        }
    }
}
