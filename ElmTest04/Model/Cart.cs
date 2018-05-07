using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cart
    {
        private IProductRepository _productRepository;

        public Cart(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        private List<CartLine> lineCollection = new List<CartLine>();

        // added the product to he Cart and populate the Cartline items list.
        public void AddItem(int productId, int quantity)
        {
            CartLine line = lineCollection
                .Where(p => p.Product.Id == productId)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Product = _productRepository.FindByID(productId),
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public void RemoveLine(int productId)
        {
            lineCollection.RemoveAll(l => l.Product.Id == productId);
        }

        // gets the total items ordered.
        public List<CartLine> GetTotalItemsOrdered()
        {
            return lineCollection;

        }
        public void Clear()
        {
            lineCollection.Clear();
        }
    }
    public class CartLine
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
