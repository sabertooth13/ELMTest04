using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IList<Product> ApplyOfferToProducts(ProductType productName)
        {
            IOfferStratergy offerStratergy = OfferFactory.GetOfferStratergyFor(productName);
            IList<Product> products = _productRepository.FindAllByType(productName);
            products.ApplyPromoOffers(offerStratergy);
            return products;
        }
    }
}
