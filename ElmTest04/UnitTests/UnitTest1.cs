using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Repository;
using Service;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ProductRepository repository = new ProductRepository();
            IList<Product> prods = repository.FindAll();

            ProductService productService = new ProductService(repository);
            productService.ApplyOfferToProducts(ProductType.A);
            productService.ApplyOfferToProducts(ProductType.B);
            productService.ApplyOfferToProducts(ProductType.c);
            IList<Product> prod1s = repository.FindAll();
            Cart cart = new Cart(new ProductRepository());

            // to add a product to the cart , we give the productID and no of Products;

            cart.AddItem(1, 2);
            cart.AddItem(2, 3);
            cart.AddItem(3, 5);
            cart.GetTotalItemsOrdered();

        }
    }
}
