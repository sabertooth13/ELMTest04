using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product
    {
        public int Id { get; set; }
        public ProductType Name { get; set; }
        public Price Price { get; set; }


    }
    public enum ProductType
    {
        A,
        B,
        c
    }
    public enum OfferType
    {
        BuyOneGetOne,
        ThreeForTenEuro,
        None
    }
}
