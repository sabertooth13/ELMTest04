using Model;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProductRepository : IProductRepository
    {


        List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name=ProductType.A,Price=new Price(20)},
                new Product{Id=2,Name=ProductType.B,Price=new Price(4)},
                new Product{Id=3,Name=ProductType.c,Price=new Price(2)}
            };
        public IList<Product> FindAll()
        {

            return products;

        }

        public Product FindByID(int id)
        {
            return products.FirstOrDefault(prod => prod.Id == id);
        }
        public IList<Product> FindAllByType(ProductType productName)
        {
            IList<Product> productFound = products.FindAll(prod => prod.Name == productName);
            return productFound;
        }
    }
}
