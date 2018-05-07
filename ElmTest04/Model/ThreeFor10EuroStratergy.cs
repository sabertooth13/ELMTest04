using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ThreeFor10EuroStratergy : IOfferStratergy
    {
        public OfferType ApplyDiscountTo(OfferType offer)
        {
            return OfferType.ThreeForTenEuro;
        }
    }
}
