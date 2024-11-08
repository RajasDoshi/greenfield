using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCO;
using Specification;
using BinaryDataRepositoryLib;

namespace Services
{
    public class ProductService : IProductService
    {
        public bool Seeding()
        {

            bool status = false;
            List<Product> products = new List<Product>();
            products.Add(new Product { Id = 1, Name = "gerbera", Description = "Wedding Flower", cost = 12, Quantity = 5000, Img = "/Images/gerbera.jpg" });
            products.Add(new Product { Id = 2, Name = "rose", Description = "Wedding Flower", cost = 11, Quantity = 4000, Img = "/Images/rose.jfif" });
            products.Add(new Product { Id = 3, Name = "lily", Description = "Wedding Flower", cost = 2, Quantity = 5000, Img = "" });
            products.Add(new Product { Id = 4, Name = "jasmine", Description = "Wedding Flower", cost = 22, Quantity = 5000, Img = "" });
            products.Add(new Product { Id = 5, Name = "lotus", Description = "Wedding Flower", cost = 19, Quantity = 3000, Img = "" });
            IDataRepository repository = new BinaryRepository();
            status = repository.Serialize("products.dat", products);
            return status;
        }

        private List<Product> products;
        public ProductService()
        {
            this.products = new List<Product>();
        }
        public bool Delete(int id)
        {
            Product theProduct = this.Get(id);
            if (theProduct != null)
            {
                List<Product> allProducts = GetAll();
                allProducts.Remove(theProduct);
                IDataRepository repo = new BinaryRepository();
                repo.Serialize("products.dat", allProducts);
                return true;
            }
            return false;
        }

        public Product Get(int id)
        {
            Product foundProduct = null;
            List<Product> products = GetAll();
            foreach (Product p in products)
            {
                if (p.Id == id)
                {
                    foundProduct = p;
                }
            }
            return foundProduct;
        }

        public List<Product> GetAll(string filename = "products.dat")
        {
            string FileName = filename;
            List<Product> products = new List<Product>();
            IDataRepository repository = new BinaryRepository();
            products = repository.Deserialize(filename);
            return products;
        }

        public bool Insert(Product Product)
        {
            List<Product> allProducts = GetAll();
            allProducts.Add(Product);
            IDataRepository repository = new BinaryRepository();
            repository.Serialize("products.dat", allProducts);
            return true;
        }

        public bool Update(Product productToBeUpdated)
        {
            Product theProduct = this.Get(productToBeUpdated.Id);
            if (theProduct != null)
            {
                List<Product> allProducts = GetAll();
                allProducts.Remove(theProduct);
                IDataRepository repository = new BinaryRepository();
                repository.Serialize("products.dat", allProducts);
            }
            return true;

        }
    }
}