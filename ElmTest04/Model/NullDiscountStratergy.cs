using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class NullDiscountStratergy : IOfferStratergy
    {
        // No offer for the products.
        public OfferType ApplyDiscountTo(OfferType offer)
        {
            return OfferType.None;
        }
    }
}
