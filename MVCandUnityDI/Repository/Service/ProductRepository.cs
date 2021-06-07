using MVCandUnityDI.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCandUnityDI.Repository.Service
{
    
    public class ProductRepository : IProductRepository
    {
        List<Product> products = new List<Product>();
        private int next_id = 1;

        public ProductRepository()
        {
            // Add products for the Demonstration
            Add(new Product { Name = "Computer", Category = "Electronics", Price = 23.54M });
            Add(new Product { Name = "Laptop", Category = "Electronics", Price = 33.75M });
            Add(new Product { Name = "iPhone4", Category = "Phone", Price = 16.99M });

        }

        public Product Add(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("Item", "item object cannot be empty");
            }

            //Write the code that saves in your db
            item.Id = next_id++;
            products.Add(item);

            return item;
        }

        public IEnumerable<Product> GetAll()
        {
            return products.ToList();
        }

        public Product GetID(int Id)
        {
            return products.Where(p => p.Id == Id).FirstOrDefault();
        }

        public bool Update(Product item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }

            // TO DO : Code to update record into database
            int index = products.FindIndex(p => p.Id == item.Id);
            if (index == -1)
            {
                return false;
            }
            products.RemoveAt(index);
            products.Add(item);

            return true;
        }

        public bool Delete(int id)
        {
            // TO DO : Code to remove the records from database
            products.RemoveAll(p => p.Id == id);

            return true;
        }
    }
}