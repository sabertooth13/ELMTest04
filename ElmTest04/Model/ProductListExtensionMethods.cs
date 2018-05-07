using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class ProductListExtensionMethods
    {

        // Extension method to apply offers to all the products in one go.
        public static void ApplyPromoOffers(this IList<Product> products, IOfferStratergy offerStratergy)
        {
            foreach (Product p in products)
            {
                p.Price.SetOfferStratergyTo(offerStratergy);
            }
        }

    }
}
