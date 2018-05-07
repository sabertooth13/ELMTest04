using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Buy1Get1Stratergy : IOfferStratergy
    {
        public OfferType ApplyDiscountTo(OfferType offer)
        {
            return OfferType.BuyOneGetOne;
        }
    }
}
