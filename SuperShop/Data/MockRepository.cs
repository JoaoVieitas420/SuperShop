using SuperShop.Data.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SuperShop.Data
{
    public class MockRepository : IRepository
    {
        public void AddProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            var products = new List<Product>();
            products.Add(new Product { ID = 1, Name = "Um", Price = 10 });
            products.Add(new Product { ID = 2, Name = "Dois", Price = 10 });
            products.Add(new Product { ID = 3, Name = "Tres", Price = 10 });
            products.Add(new Product { ID = 4, Name = "Quatro", Price = 10 });
            products.Add(new Product { ID = 5, Name = "Cinco", Price = 10 });

            return products;
        }

        public bool ProductExists(int id)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveProduct(Product product)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> SaveAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateProduct(Product product)
        {
            throw new System.NotImplementedException();
        }
    }
}
