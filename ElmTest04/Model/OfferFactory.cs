using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public static class OfferFactory
    {
        public static IOfferStratergy GetOfferStratergyFor(ProductType productName)
        {
            switch (productName)
            {
                case ProductType.A:
                    return new Buy1Get1Stratergy();
                case ProductType.B:
                    return new ThreeFor10EuroStratergy();
                case ProductType.c:
                default:
                    return new NullDiscountStratergy();

            }
        }
    }
}
