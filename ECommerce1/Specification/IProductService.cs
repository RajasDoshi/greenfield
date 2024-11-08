﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;
namespace Specification
{
   public interface IProductService
    {
        List<Product> GetAll(string s);
        Product Get(int id);
        bool Insert(Product product);
        bool Update(Product product);
        bool Delete(int id);


    }
}
