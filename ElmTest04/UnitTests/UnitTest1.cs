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
        public void TestCartCheckOut()
        {
            // we need to be able to apply offers to a specific group of products.[like all products in a 
            // given category or something .
            // For the purpose of demonstration i am interchanginly using ProductName as ProductType because
            // it would be easy to add new products in future and apply same discount all the products of the same type if we wish so.

            /*
              List<Product> products = new List<Product>()
            {
                new Product{Id=1,Name=ProductType.A,Price=new Price(20)},
                new Product{Id=2,Name=ProductType.B,Price=new Price(4)},
                new Product{Id=3,Name=ProductType.c,Price=new Price(2)}
            };

            this is the product store we are dealing with right now in these unit tests.


             */

            ProductService productService = new ProductService(new ProductRepository());
            productService.ApplyOfferToProducts(ProductType.A);
            productService.ApplyOfferToProducts(ProductType.B);
            productService.ApplyOfferToProducts(ProductType.c);
            Cart cart = new Cart(new ProductRepository());


            // to add a product to the cart , we give the productID and no of Products;

            cart.AddItem(1, 2);
            cart.AddItem(2, 3);
            cart.AddItem(3, 5);
            CheckOutService checkOut = new CheckOutService();
            checkOut.CalcualteTotal(cart.GetTotalItemsOrdered());
            Assert.AreEqual(40, checkOut.Total);

        }

        [TestMethod]
        public void TestCartCheckOutGeneralCase()
        {

            /*
            this test uses the same product store as the above one , but this time.
            we are picking up extra products outside of the offer.
            for eg : when we pick 2 products for buy1get1 , then we get both of them
            'for the price of 1 , but insted if we take 3 , i am assuming that , 
            two will get the offer and then the remaining one would have to be brought at its normal price.
            the same logic would be applicable for 3for10 euro offer as well.
            if we pick 4 , 3 will cost 10 on offer and the 4th one will have to brought at its normal price.


            */
            ProductService productService = new ProductService(new ProductRepository());
            productService.ApplyOfferToProducts(ProductType.A);
            productService.ApplyOfferToProducts(ProductType.B);
            productService.ApplyOfferToProducts(ProductType.c);
            Cart cart = new Cart(new ProductRepository());
            int cartItmQty1 = 5;
            cart.AddItem(1, cartItmQty1);
            int cartItmQty2 = 7;
            cart.AddItem(2, cartItmQty2);
            int cartItmQty3 = 5;
            cart.AddItem(3, cartItmQty3);
            CheckOutService checkOut = new CheckOutService();
            checkOut.CalcualteTotal(cart.GetTotalItemsOrdered());
            Assert.AreEqual(94, checkOut.Total);
        }
    }
}
