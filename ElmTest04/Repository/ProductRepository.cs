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
        public IList<Product> FindAll()
        {
            List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name=ProductType.A,Price= new Price{ Amt=20,OfferType=OfferType.BuyOneGetOne} },
                new Product{Id=2,Name=ProductType.B,Price=new Price{Amt=4,OfferType=OfferType.ThreeForTenEuro } },
                new Product{Id=3,Name=ProductType.c,Price=new Price{Amt=5,OfferType=OfferType.None }}
            };

            return products;


        }
    }
}
